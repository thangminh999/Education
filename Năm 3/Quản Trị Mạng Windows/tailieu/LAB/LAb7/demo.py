import csv
import os

#doc file
csvfile = open("DATASERVER.csv","r")
doc = csv.reader(csvfile)


# Tach ten
def TachTen(ten):
    a = ten.split(" ")
    t=a[-1]
    for i in range(len(a)-1):
        t=t+a[i][0]
    return t

for txt in doc:
    # print(txt[2])
    # print(txt[1])
    print(TachTen(txt[0]))

