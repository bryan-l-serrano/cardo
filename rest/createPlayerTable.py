#!/usr/bin/python
import sqlite3
import os

home = os.path.expanduser('~')
conn = sqlite3.connect(home + '/cardo/cardo.db')

print('opened database')

cursor = conn.cursor()

cursor.execute("DROP TABLE IF EXISTS PLAYER")

sqlCommand = '''CREATE TABLE PLAYERS(
id CHAR(20) PRIMARY KEY NOTNULL,
userName CHAR(20) INIQUE NOTNULL,
password CHAR(255) NOTNULL,
gamesPlayed INT NOTNULL,
gamesWon INT NOTNULL,
email CHAR(50)
)'''

cursor.execute(sqlCommand)

conn.commit()

print('created table')

conn.close()

