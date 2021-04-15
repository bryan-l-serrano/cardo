#!/usr/bin/python
import sqlite3
import string
import os


def getPlayerByID(playerData):
    data = (playerData.id)
    home = os.path.expanduser('~')
    conn = sqlite3.connect(home + '/cardo/cardo.db')
    cursor = conn.cursor()

    sqlCommand = """SELECT * FROM PLAYER WHERE id = (?)"""

    returnData = cursor.execute(sqlCommand, data)

    conn.commit()

    conn.close()

    return returnData


def getPlayerByUserName(playerData):
    data = (playerData.userName)
    home = os.path.expanduser('~')
    conn = sqlite3.connect(home + '/cardo/cardo.db')
    cursor = conn.cursor()

    sqlCommand = """SELECT * FROM PLAYER WHERE userName = (?)"""

    returnData = cursor.execute(sqlCommand, data)

    conn.commit()

    conn.close()

    return returnData
