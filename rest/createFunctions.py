#!/usr/bin/python
import sqlite3
import random
import string
import os

def createID():
    return ''.join(random.sample(string.ascii_letters + string.digits, k=20))

def createPlayer(playerData):
    data = (createID(), playerData["userName"], playerData['password'], 0, 0, playerData['email'])
    print(data)
    conn = sqlite3.connect('/cardo/cardo.db')
    print('connected to db')
    cursor = conn.cursor()

    cursor.execute("INSERT INTO PLAYER VALUES (?,?,?,?,?,?)", data)
    print('executed sql command')
    conn.commit()

    print('closing connection to db')
    conn.close()

    return True
    
