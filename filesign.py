# -*- codeing = utf-8 -*-
from bs4 import BeautifulSoup  # 网页解析，获取数据
import requests
import unicodedata as ucd

currentPage = 1
order = 'EXT'
pageCount = 1

baseExtSearchUrl = 'https://www.filesignatures.net/index.php?page=search'


def main():
    baseUrl = 'https://www.filesignatures.net/index.php?page=all'
    data = getData(baseUrl)
    for item in data:
        print(item.ext)
        print(item.byte)
        print(item.desc)


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
    for page in range(1, int(2) + 1):
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
            #如果上一个搜索的后缀和当前后缀一样，则不必重复搜索同名扩展
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


if __name__ == "__main__":  # 当程序执行时
    # 调用函数
    main()
    # init_db("movietest.db")
    print("爬取完毕！")
