# -*- codeing = utf-8 -*-
from os import curdir
from bs4 import BeautifulSoup  # 网页解析，获取数据
import requests
import unicodedata as ucd
import xlwt

currentPage = 1
order = 'EXT'
pageCount = 1
baseExtSearchUrl = 'https://www.filesignatures.net/index.php?page=search'
baseUrl = 'https://www.filesignatures.net/index.php?page=all'


def main():
    data = getData(baseUrl)
    # #输出数据
    # for item in data:
    #     print(item.ext)
    #     print(item.byte)
    #     print(item.desc)
    saveData(data, 'output.xls')
    saveCsDict(data)

class FileSignature:
    ext = ''
    byte = ''
    desc = ''
    size = 0
    offest = 0

# 获取所有数据


def getData(baseUrl):
    indexHtml = requests.get(baseUrl)
    soup = BeautifulSoup(indexHtml.text, 'lxml')
    pageOptions = soup.select('#pageList #pageinate #select > option')
    pageCount = pageOptions[-1].text
    ret = []
    for page in range(1, int(pageCount) + 1):
        print(page)
        page = getPageData(baseUrl, page)
        for t in page:
            ret.append(t)
    return ret


# 获取某页数据
def getPageData(baseUrl, page):
    pageHtml = getPageHtml(baseUrl, page)
    # print(pageHtml.text)
    soup = BeautifulSoup(pageHtml, 'lxml')
    data = soup.select('#results > a')
    ret = []

    index = 1
    tempExt = ''
    lastExt = ''
    for item in data:
        if index == 1:
            tempExt = item.text
            index = index+1
        else:
            index = 1
            if tempExt == "*":
                continue
            # 如果上一个搜索的后缀和当前后缀一样，则不必重复搜索同名扩展
            if tempExt == lastExt:
                continue
            lastExt = tempExt
            list = getExtData(tempExt)
            for t in list:
                ret.append(t)
    return ret


# 获取某一页的html内容
def getPageHtml(baseUrl, page):
    pageHtml = requests.get(
        baseUrl, params={'currentpage': page, 'order': order})
    return pageHtml.text


# 获取某个后缀的信息
def getExtData(ext):
    print('搜索ext为' + ext + '的数据')
    extHtml = getExtHtml(ext)
    # print(extHtml)
    soup = BeautifulSoup(extHtml, 'lxml')
    data = soup.select('#innerTable > tr > td')
    ret = []
    skip = 1
    dataIndex = 0
    temp = FileSignature()
    for item in data:
        if skip <= 4:
            skip = skip + 1
            continue
        if dataIndex == 0:
            dataIndex += 1
            continue
        if(dataIndex == 1):  # 扩展名称
            dataIndex += 1
            # print(item.text)
            temp.ext = item.text
            continue
        if(dataIndex == 2):  # 字节
            dataIndex += 1
            # print(item.text)
            temp.byte = item.text
            continue
        if(dataIndex == 3):  # 描述
            dataIndex += 1
            # print(item.text)
            temp.desc = item.text
            continue
        if(dataIndex == 4):  # 空行
            dataIndex += 1
            # print(item.text)
            continue
        if(dataIndex == 5):  # 空行
            dataIndex += 1
            # print(item.text)
            continue
        if(dataIndex == 6):  # 空行
            dataIndex += 1
            # print(item.text)
            continue
        if(dataIndex == 7):  # Sizet:    8 Bytes Offset:  0 Bytes
            dataIndex = 0
            text = ucd.normalize('NFKC', item.text).replace(
                '\r', '').replace('\n', '').replace(' ', '') + 'end'
            size = text[text.index('Sizet:') +
                        6: text.index('BytesOffset:')]  # 字节大小
            offset = text[text.index('Offset:') +
                          7: text.index('Bytesend')]  # 字节偏移量
            temp.size = int(size)
            temp.offest = int(offset)
            # print(text)
            # print(size)
            # print(offset)

            # 实例化一个新对象
            t = FileSignature()
            t.ext = temp.ext
            t.byte = temp.byte
            t.desc = temp.desc
            t.size = temp.size
            t.offest = temp.offest
            ret.append(t)
            continue

    return ret


def getExtHtml(ext):
    extHtml = requests.get(baseExtSearchUrl, params={
                           'search': ext, 'mode': 'EXT'})
    return extHtml.text


def saveData(list, path):
    print('save.........')
    book = xlwt.Workbook(encoding="utf-8", style_compression=0)  # 创建workbook对象
    sheet = book.add_sheet('sign', cell_overwrite_ok=True)  # 创建工作表
    col = ("Ext", "Byte", "Desc", "Size", "Offest")
    for i in range(0, 5):
        sheet.write(0, i, col[i])  # 列名
    for i in range(0, len(list)):
        # print("第%d条" %(i+1))       #输出语句，用来测试
        data = list[i]
        sheet.write(i+1, 0, data.ext)
        sheet.write(i+1, 1, data.byte)
        sheet.write(i+1, 2, data.desc)
        sheet.write(i+1, 3, data.size)
        sheet.write(i+1, 4, data.offest)
    book.save(path)  # 保存


def saveCsDict(list):
    print('save cs......')
    same=[]
    current=''
    data = open('output.cs', 'w+')
    print('using System.Collections.Generic;', file=data)
    print('', file=data)
    print('namespace MagicNumber', file=data)
    print('{', file=data)
    print('    public class FileSignature', file=data)
    print('    {', file=data)
    print('        public static readonly Dictionary<string, List<MagicNumberRecord>> Default = new Dictionary<string, List<MagicNumberRecord>>', file=data)
    print('        {', file=data)
    for item in list:
        if current == '':
            current = item.ext
        if current == item.ext:
            same.append(item)
        else:
            print('            {', file=data)
            print('                "'+ current.lower() +'", new List<MagicNumberRecord> {', file=data)
            i = 0
            l = len(same)
            for s in same:
                i+=1
                bytes = s.byte.split(' ')
                # print(bytes)
                byteStr = ''
                for b in bytes:
                    if b=='' or b == ' ':
                        continue
                    byteStr = byteStr + ' 0x' + b + ','
                byteStr = byteStr[0:len(byteStr)-1]
                end= ''
                if i != l:
                    end=','
                print('                    new MagicNumberRecord(){ Number = new byte[] { '+byteStr+' }, Offset = '+str(s.offest)+', Size = '+str(s.size)+' }'+end+'', file=data)
            print('                }', file=data)
            print('            },', file=data)
            #下一个ext
            current = item.ext
            same=[]
            same.append(item)
    print('        };', file=data)
    print('    }', file=data)
    print('}', file=data)


if __name__ == "__main__":  # 当程序执行时
    # 调用函数
    main()
    # init_db("movietest.db")
    print("爬取完毕！")
