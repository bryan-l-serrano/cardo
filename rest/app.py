from flask import Flask, request, jsonify, Response
import createFunctions
import readFunctions
import updateFunctions
import deleteFunctions
import json

app = Flask(__name__)


#### DO ####


#######################################
#CREATE
@app.route('/newPlayer', methods=['POST'])
def createPlayer():
    if not request.json:
        return json.dumps({"STATUS": "ERROR", "message": "No request sent"}), 400
    playerData = request.get_json()
    try:
        createFunctions.createPlayer(playerData)
    except:
        return Response(json.dumps({"STATUS": "ERROR", "message": "something went wrong with the request"}), 400, mimetype='application/json')
    else:
        return Response(json.dumps({"STATUS": "SUCCESS", "message": "player successfully created"}), 201, mimetype='application/json')



#########################################
#READ

@app.route('/player', methods =['GET'])
def getAllPlayers():
    try:
        playerData = readFunctions.getAllPlayers()
    except:
        return Response(json.dumps({"STATUS": "ERROR", "message": "something went wrong with the request"}), 400, mimetype='application/json')
    else:
        return Response(json.dumps(playerData), 200, mimetype='application/json')



@app.route('/player/id/<id>', methods=['GET'])
def getPlayerByID(id):
    try:
        playerData = readFunctions.getPlayerByID(str(id))
    except:
        return Response(json.dumps({"STATUS": "ERROR", "message": "something went wrong with the request"}), 400, mimetype='application/json')
    else:
        return Response(json.dumps(playerData), 200, mimetype='application/json')



@app.route('/player/userName/<username>', methods=['GET'])
def getPlayerByUserName(username):
    try:
        playerData = readFunctions.getPlayerByUserName(str(username))
    except:
        return Response(json.dumps({"STATUS": "ERROR", "message": "something went wrong with the request"}), 400, mimetype='application/json')
    else:
        return Response(json.dumps(playerData[0]), 200, mimetype='application/json')

##############################################
###UPDATE

@app.route('/player/update/password', methods=['POST'])
def updatePassword():
    if not request.json:
        return json.dumps({"STATUS": "ERROR", "message": "No request sent"}), 400
    playerData = request.get_json()
    playerId = playerData['id']
    newPassword = playerData['newPassword']
    try:
        returnData = updateFunctions.updatePlayerPassword(playerId,newPassword)
    except:
        return Response(json.dumps({"STATUS": "ERROR", "message": "something went wrong with the request"}), 400, mimetype='application/json')
    else:
       return Response(json.dumps(returnData), 200, mimetype='application/json')


@app.route('/player/update/games', methods=['POST'])
def updateGames():
    if not request.json:
        return Response(json.dumps({"STATUS": "ERROR", "message": "No request sent"}), 400, mimetype='application/json')
    playerData = request.get_json()
    playerId = playerData['id']
    playerWon = playerData['win']
    gamesPlayed = playerData['gamesPlayed']
    gamesWon = playerData['gamesWon']

    try:
        returnData = updateFunctions.updatePlayerGames(playerId, playerWon, gamesPlayed, gamesWon)
    except:
        return Response(json.dumps({"STATUS": "ERROR", "message": "something went wrong with the request"}), 400, mimetype='application/json')
    else:
        return Response(json.dumps(returnData), 200, mimetype='application/json')



@app.route('/player/update/email', methods=['POST'])
def updateEmail():
    if not request.json:
        return json.dumps({"STATUS": "ERROR", "message": "No request sent"}), 400
    playerData = request.get_json()
    playerId = playerData['id']
    newEmail = playerData['newEmail']
    try:
        returnData = updateFunctions.updatePlayerEmail(playerId,newEmail)
    except:
        return Response(json.dumps({"STATUS": "ERROR", "message": "something went wrong with the request"}), 400, mimetype='application/json')
    else:
       return Response(json.dumps(returnData), 200, mimetype='application/json')


###################################################
###DELETE

@app.route('/player/id/<playerId>/delete', methods=['GET'])
def deletePlayer(playerId):
    try:
        deleteFunctions.deletePlayer(playerId)
    except:
        return Response(json.dumps({"STATUS": "ERROR", "message": "something went wrong with the request"}), 400, mimetype='application/json')
    else:
        return Response(json.dumps({"STATUS":"SUCCESS", "playerData":"player deleted"}), 204, mimetype='application/json')
        
    

######################################################

if __name__ == '__main__':
    app.run(host='0.0.0.0', debug=True, port=5000)
