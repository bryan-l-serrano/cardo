#!/usr/bin/python
import sqlite3

conn = sqlite3.connect('~/cardo/cardo.db')

print('opened database')

conn.execute('''CREATE TABLE PLAYERS
(
id CHAR(20) PRIMARY KEY NOTNULL,
userName CHAR(20) NOTNULL UNIQUE,
password CHAR(255) NOTNULL,
gamesPlayed INT NOTNULL,
gamesWon INT NOTNULL,
email CHAR(50)
);
''')


print('created table')

conn.close()

