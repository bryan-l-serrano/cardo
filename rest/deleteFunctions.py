#!/usr/bin/python
import sqlite3
import string
import os

def deletePlayer(playerId):
    conn = sqlite3.connect('/cardo/cardo.db')
    conn.row_factory = sqlite3.Row
    cursor = conn.cursor()
    cursor.execute("DELETE FROM PLAYER WHERE id = ?", (playerId,))
    conn.commit()
    conn.close()