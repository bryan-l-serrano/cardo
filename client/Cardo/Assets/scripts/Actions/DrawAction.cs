using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawAction
{
    //SINGLETON *****************************
	private static DrawAction instance = null;
	public static DrawAction GetInstance
	{
		get
		{
			if (instance == null)
				instance = new DrawAction();
			return instance;
		}
	}
	
	private DrawAction()
	{
        cardsDrawn = new Deck();
        gameState = GameState.GetInstance;
        playerClass = PlayerClass.GetInstance;
	}
    // ****************************************

    public int numberOfCardsToDraw;
    public Deck cardsDrawn;

    private GameState gameState;
    private PlayerClass playerClass;

    public void drawCards(){
        Debug.Log("Beginning to Draw" + numberOfCardsToDraw + " Cards------------");

        for (int i = 0; i < numberOfCardsToDraw; i++)
        {
           cardsDrawn.addCard(gameState.drawCard(playerClass.playerType));
        }

        Debug.Log("PLAYER HAND AFTER DRAWING---------------------------");
        Debug.Log(gameState.player1Hand.getStringOfCards());
        Debug.Log("----------------------------------------------------");

    }

}