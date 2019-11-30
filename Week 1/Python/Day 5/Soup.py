import pymysql
import urllib.request as urllib
from bs4 import BeautifulSoup

def createtable():
        db = pymysql.connect("localhost","root","","test")
        cursor = db.cursor()
        cursor.execute("""CREATE TABLE TOP_LOSERS_NIFTY(
                  COMPANY CHAR(20),
                  PRICE FLOAT,
                  CHANGE FLOAT,
                  LOSS FLOAT
                   )""")
        cursor.execute('''CREATE TABLE TOP_LOSERS_SENSEX (
                 COMPANY  CHAR(20),
                 PRICE  FLOAT,
                 CHANGE1 FLOAT,
                 LOSS FLOAT
                  )''')
#createtable()
db = pymysql.connect("localhost","root","","test")
cursor = db.cursor()
r=urllib.urlopen('https://www.moneycontrol.com/').read()
soup=BeautifulSoup(r,'lxml')
divs=[soup.find_all('div',attrs={'id':'tlNifty'}),soup.find_all('div',attrs={'id':'tlSensex'})]
for k in divs:
    if k==divs[0]:
        a = 'TOP_LOSERS_NIFTY'
    else:
        a = 'TOP_LOSERS_SENSEX'
    for j in k[0].tbody.find_all('tr'):
        c = []
        for i in j.find_all('td'):
            c.append(i.get_text())
        cursor.execute("""INSERT INTO {0}(COMPANY,PRICE,CHANGE1,LOSS)
                       VALUES ('{1}',{2},{3},{4})""".format(a, c[0], c[1], c[2], c[3]))
        db.commit()
db.close()
