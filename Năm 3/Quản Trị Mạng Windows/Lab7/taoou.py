import os
import csv

#tao ou
csvfile = open("DATASERVER.csv","r")
doc = csv.reader(csvfile)

domain="dc=thanghnm,dc=com"
def tao1ou(ou,domain):
    com="dsadd ou "+ chr(34)+"ou="+ou+","+domain + chr(34)
    # dsOU.append(ou)
    os.system(com)
    print(com)

for txt in doc:
    tao1ou(txt[2],domain)