#!/usr/bin/python
import sqlite3
import string
import os

def updatePlayerPassword(playerId, newPassword):
    home = os.path.expanduser('~')
    conn = sqlite3.connect(home + '/cardo/cardo.db')
    conn.row_factory = sqlite3.Row
    cursor = conn.cursor()
    cursor.execute("UPDATE PLAYER SET password = ? WHERE id = ?", (newPassword,playerId,))
    cursor.execute("SELECT * FROM PLAYER WHERE id = ?", (playerId,))
    returnData = [dict(row) for row in cursor.fetchall()]
    conn.commit()
    conn.close()
    return returnData


def updatePlayerGames(playerId, playerWon, gamesPlayed, gamesWon):
    home = os.path.expanduser('~')
    conn = sqlite3.connect(home + '/cardo/cardo.db')
    conn.row_factory = sqlite3.Row
    cursor = conn.cursor()
    if playerWon == True:  
        cursor.execute("UPDATE PLAYER SET gamesPlayed = ?, gamesWon = ? WHERE id = ?", (gamesPlayed + 1,gamesWon + 1, playerId,))
    else:
        cursor.execute("UPDATE PLAYER SET gamesPlayed = ? WHERE id = ?", (gamesPlayed + 1,playerId,))
    cursor.execute("SELECT * FROM PLAYER WHERE id = ?", (playerId,))
    returnData = [dict(row) for row in cursor.fetchall()]
    conn.commit()
    conn.close()
    return returnData


def updatePlayerEmail(playerId, newEmail):
    home = os.path.expanduser('~')
    conn = sqlite3.connect(home + '/cardo/cardo.db')
    conn.row_factory = sqlite3.Row
    cursor = conn.cursor()
    cursor.execute("UPDATE PLAYER SET email = ? WHERE id = ?", (newEmail,playerId,))
    cursor.execute("SELECT * FROM PLAYER WHERE id = ?", (playerId,))
    returnData = [dict(row) for row in cursor.fetchall()]
    conn.commit()
    conn.close()
    return returnData