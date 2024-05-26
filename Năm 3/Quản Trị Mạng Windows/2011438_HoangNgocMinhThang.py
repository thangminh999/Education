import csv
import os
csvfile = open("DATASERVER.csv","r")
doc = csv.reader(csvfile)
# for txt in doc:
#     print(txt[2])
#     print(txt[1])
#     print(txt[0])
def TachTen(ten):
    a = ten.split(" ")
    tenho = a[-1]
    for i in range(len(a)-1):
        tenho=tenho+a[i][0]
    return tenho
# for txt in doc:
#     print(TachTen(txt[0]))
domain="dc=thanghnm,dc=com"

def tao1ou(ou,domain):
    com="dsadd ou "+ chr(34)+"ou="+ou+","+domain+chr(34)
    # dsOU.append(ou)
    os.system(com)
    print(com)

# for txt in doc:
#     tao1ou(txt[2],domain)

def tao1user(username,ou,domain, password):
    pathProfile =" -profile "+chr(92)+chr(92)+"192.168.10.133\\profiles\\"+username
    com="dsadd user "+ chr(34)+"cn="+username+",ou="+ou+","+domain+chr(34)+" -pwd"+" " +password  +pathProfile
    os.system(com)
    print(com)
# for txt in doc:
#     tao1user(TachTen(txt[0]),txt[2],domain,txt[1])
import csv
import os
csvfile = open("DATASERVER.csv","r")
doc = csv.reader(csvfile)
# for txt in doc:
#     print(txt[2])
#     print(txt[1])
#     print(txt[0])
def TachTen(ten):
    a = ten.split(" ")
    tenho = a[-1]
    for i in range(len(a)-1):
        tenho=tenho+a[i][0]
    return tenho
# for txt in doc:
#     print(TachTen(txt[0]))
domain="dc=thanghnm,dc=com"

def tao1ou(ou,domain):
    com="dsadd ou "+ chr(34)+"ou="+ou+","+domain+chr(34)
    # dsOU.append(ou)
    os.system(com)
    print(com)

# for txt in doc:
#     tao1ou(txt[2],domain)

""" def taongdung(username):
    folder_path = '/dungchung/'+username
    os.mkdir(folder_path)
for txt in doc:
    taongdung(TachTen(txt[0])) """

def tao1user(username,ou,domain, password):
    pathProfile =" -profile "+chr(92)+chr(92)+"10.0.10.3\\profiles\\"+username
    pathHomeDir = " -hmdir "+chr(92)+chr(92)+"10.0.10.3\\dungchung\\"+username+" -hmdrv Z:"
    com="dsadd user "+ chr(34)+"cn="+username+",ou="+ou+","+domain+chr(34)+" -pwd"+" " +password + pathHomeDir  +pathProfile
    os.system(com)
    print(com)
for txt in doc:
    tao1user(TachTen(txt[0]),txt[2],domain,txt[1])
def xoa1user(username,ou,domain):
    pathProfile =" -profile "+chr(92)+chr(92)+"10.0.10.3\\profiles\\"+username
    com="dsrm user "+ chr(34)+"cn="+username+",ou="+ou+","+domain+chr(34)
    os.system(com)
    print(com)
""" for txt in doc:
     xoa1user(TachTen(txt[0]),txt[2],domain) """
