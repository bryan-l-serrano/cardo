from flask import Flask, request, jsonify, Response
import createFunctions
import readFunctions
import json

app = Flask(__name__)


#######################################
#CREATE
@app.route('/newPlayer', methods=['POST'])
def createPlayer():
    if not request.json:
        return json.dumps({"STATUS": "ERROR", "message": "No request sent"}), 400
    playerData = request.get_json()
    print(playerData)
    try:
        createFunctions.createPlayer(playerData)
    except:
        return Response(json.dumps({"STATUS": "ERROR", "message": "something went wrong with the request"}), 400, mimetype='application/json')
    else:
        return Response(json.dumps({"STATUS": "SUCCESS", "message": "player successfully created"}), 204, mimetype='application/json')



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
        return Response(json.dumps({"STATUS":"SUCCESS", "playerData":playerData}), 200, mimetype='application/json')



@app.route('/player/userName/<username>', methods=['GET'])
def getPlayerByUserName(username):
    try:
        playerData = readFunctions.getPlayerByUserName(str(username))
    except:
        return Response(json.dumps({"STATUS": "ERROR", "message": "something went wrong with the request"}), 400, mimetype='application/json')
    else:
        return Response(json.dumps({"STATUS":"SUCCESS", "playerData":playerData}), 200, mimetype='application/json')



###########################################
if __name__ == '__main__':
    app.run(host='0.0.0.0', debug=True, port=5000)
