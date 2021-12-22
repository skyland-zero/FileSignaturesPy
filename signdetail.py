# -*- codeing = utf-8 -*-
from typing import Any
from bs4 import BeautifulSoup  # 网页解析，获取数据
import requests
import unicodedata as ucd

baseExtSearchUrl = 'https://www.filesignatures.net/index.php?page=search&search=3GP&mode=EXT'

html = requests.get(baseExtSearchUrl)
soup = BeautifulSoup(html.text, 'lxml')
data = soup.select('#innerTable > tr > td')
# print(data)


class FileSignature:
    ext = ''
    byte = ''
    desc = ''
    size = 0
    offest = 0


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

for r in ret:
    print(r.ext)
    print(r.byte)
