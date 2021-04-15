#!/usr/bin/python
import sqlite3
import random
import string
import os

def createID():
    return ''.join(random.choices(string.ascii_letters + string.digits, k=20))

def createPlayer(playerData):
    data = (createID(), playerData.userName, playerData.password, 0, 0, playerData.email)

    home = os.path.expanduser('~')
    conn = sqlite3.connect(home + '/cardo/cardo.db')
    cursor = conn.cursor()

    sqlCommand = """INSERT INTO PLAYER VALUES(?,?,?,?,?,?)"""

    cursor.execute(sqlCommand, data)

    conn.commit()

    conn.close()

    return "Player written to Database"
    
