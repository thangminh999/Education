import os
import csv

csvfile = open("DATASERVER.csv","r")
doc = csv.reader(csvfile)
domain="dc=thanghnm,dc=com"

# Tach ten
def TachTen(ten):
    a = ten.split(" ")
    t=a[-1]
    for i in range(len(a)-1):
        t=t+a[i][0]
    return t

#tao user
def tao1user(username,ou,domain, password):
    com="dsadd user "+ chr(34)+"cn="+username+",ou="+ou+","+domain+chr(34)+" -pwd"+" " +password 
    os.system(com)
    print(com)
for txt in doc:
    tao1user(TachTen(txt[0]),txt[2],domain,txt[1])