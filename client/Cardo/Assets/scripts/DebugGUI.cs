using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// THE DEBUGGUI CAN BE USED TO TEST CHANGES TO THE APPLICATION AND FUNCTIONALITY
public class DebugGUI : MonoBehaviour {
    GameState gameState;
    Text stateText;

    void Start() {
        stateText = GetComponent<UnityEngine.UI.Text>();
        gameState = GameState.GetInstance;

    }

    void Update() {
    }

    void OnGUI() {

        if( GUI.Button(new Rect(10, 10, 100, 50), "Draw a card")) {
            gameState.drawCard(PlayerType.PLAYER);
            stateText.text = "";
            foreach (Card item in gameState.playerHand.getDeck())
            {
                stateText.text += ", " + item.ToString();
            }
            //stateText.text = gameState.playerHand[0].ToString();
            //stateText.text += gameState.playerDeck.ToString();
        }
        // if(GUI.Button(new Rect(10,70,100,30), "Play Card")) {
        //     stateText.text = "";
        //     gameState.playCard(gameState.playerHand.getDeck()[0], true);
        //     foreach (Card item in gameState.playerHand.getDeck())
        //     {
        //         stateText.text += ", " + item.ToString();
        //     }

        // }
    }  
}