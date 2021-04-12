using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//TODO make better debugGUI, that displays the full game state at each update
public class DebugGUI : MonoBehaviour {
    GameState gameState;
    Text stateText;

    void Start() {
        stateText = GetComponent<UnityEngine.UI.Text>();
        gameState = new GameState();

    }

    void Update() {
    }

    void OnGUI() {

        if( GUI.Button(new Rect(10, 10, 100, 50), "Draw a card")) {
            gameState.drawCard(true);
            stateText.text = "";
            foreach (Card item in gameState.playerHand)
            {
                stateText.text += ", " + item.ToString();
            }
            //stateText.text = gameState.playerHand[0].ToString();
            //stateText.text += gameState.playerDeck.ToString();
        }
        if(GUI.Button(new Rect(10,70,100,30), "Play Card")) {
            stateText.text = "";
            gameState.playCard(gameState.playerHand[0], true);
            foreach (Card item in gameState.playerHand)
            {
                stateText.text += ", " + item.ToString();
            }

        }
    }  
}