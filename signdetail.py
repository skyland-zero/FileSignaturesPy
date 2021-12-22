# -*- codeing = utf-8 -*-
from bs4 import BeautifulSoup  # 网页解析，获取数据
import requests

baseExtSearchUrl = 'https://www.filesignatures.net/index.php?page=search&search=3GP&mode=EXT'

html = requests.get(baseExtSearchUrl)
soup = BeautifulSoup(html.text, 'lxml')
data = soup.select('#innerTable > tr > td')
# print(data)

skip = 1
dataIndex = 0

for item in data:
    if skip <= 4:
        skip = skip + 1
        continue
    if dataIndex == 0:
        dataIndex += 1
        continue
    if(dataIndex == 1):  # ext
        dataIndex += 1
        print(item.text)
        continue
    if(dataIndex == 2):  # byte
        dataIndex += 1
        print(item.text)
        continue
    if(dataIndex == 3):  # desc
        dataIndex += 1
        print(item.text)
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
        print(item.text.replace('\r', '').replace('\n', '').replace(" ", ''))
        continue
