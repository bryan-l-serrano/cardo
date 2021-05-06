#!/usr/bin/python
import sqlite3
import os

conn = sqlite3.connect('/cardo/cardo.db')

print('opened database')

cursor = conn.cursor()

cursor.execute("DROP TABLE IF EXISTS PLAYER")

sqlCommand = '''CREATE TABLE PLAYER(
id CHAR(20) PRIMARY KEY NOT NULL,
userName CHAR(20) UNIQUE NOT NULL,
password CHAR(255) NOT NULL,
gamesPlayed INT NOT NULL,
gamesWon INT NOT NULL,
email CHAR(50)
)'''

cursor.execute(sqlCommand)

conn.commit()

print('created table')

conn.close()

