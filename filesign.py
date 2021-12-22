# -*- codeing = utf-8 -*-
from bs4 import BeautifulSoup  # 网页解析，获取数据
import requests

currentPage = 1
order = 'EXT'
pageCount = 1

baseExtSearchUrl='https://www.filesignatures.net/index.php?page=search'


def main():
    baseUrl = 'https://www.filesignatures.net/index.php?page=all'
    getData(baseUrl)

#获取所有数据
def getData(baseUrl):
    indexHtml = requests.get(baseUrl)
    soup = BeautifulSoup(indexHtml.text, 'lxml')
    pageOptions = soup.select('#pageList #pageinate #select > option')
    pageCount = pageOptions[-1].text
    for page in range(1, int(2) + 1):
        print(page)
        getPageData(baseUrl, page)

#获取某页数据
def getPageData(baseUrl, page):
    pageHtml = getPageHtml(baseUrl, page)
    # print(pageHtml.text)
    soup = BeautifulSoup(pageHtml, 'lxml')
    data = soup.select('#results > a')
    index = 1
    tempExt = ''
    tempByte = ''
    for item in data:
        if index == 1:
            tempExt = item.text
            index = index+1
        else:
            tempByte = item.text
            index = 1
            if tempExt == "*":
                continue
        result = {'ext': tempExt, 'byte': tempByte}
        getSignData(tempExt)

#获取某一页的html内容
def getPageHtml(baseUrl, page):
    pageHtml = requests.get(
        baseUrl, params={'currentpage': page, 'order': order})
    return pageHtml.text

def getSignData(ext):
    signHtml = getSignHtml(ext)
    print(signHtml)

def getSignHtml(ext):
    signHtml = requests.get(baseExtSearchUrl, params={'search': ext, 'mode':'EXT'})
    return signHtml.text;

if __name__ == "__main__":  # 当程序执行时
    # 调用函数
    main()
    # init_db("movietest.db")
    print("爬取完毕！")
