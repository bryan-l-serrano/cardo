#!/usr/bin/python
import sqlite3
import string
import os


def getPlayerByID(idval):
    home = os.path.expanduser('~')
    conn = sqlite3.connect(home + '/cardo/cardo.db')
    conn.row_factory = sqlite3.Row
    cursor = conn.cursor()
    cursor.execute("SELECT * FROM PLAYER WHERE id = ?", (idval,))
    returnData = [dict(row) for row in cursor.fetchall()]
    conn.commit()
    conn.close()
    return returnData

def getAllPlayers():
    home = os.path.expanduser('~')
    conn = sqlite3.connect(home + '/cardo/cardo.db')
    conn.row_factory = sqlite3.Row
    cursor = conn.cursor()
    cursor.execute("SELECT * FROM PLAYER")
    returnData = [dict(row) for row in cursor.fetchall()]
    conn.commit()
    conn.close() 
    print(returnData)
    return returnData


def getPlayerByUserName(playerData):
    home = os.path.expanduser('~')
    conn = sqlite3.connect(home + '/cardo/cardo.db')
    conn.row_factory = sqlite3.Row
    cursor = conn.cursor()

    cursor.execute('SELECT * FROM PLAYER WHERE userName = ?', (playerData,))
    returnData = [dict(row) for row in cursor.fetchall()]
    conn.commit()

    conn.close()
    
    return returnData
