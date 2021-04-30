using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState {

	// INSTANTIATES AS A SINGLETON
	private static GameState instance = null;
	public static GameState GetInstance
	{
		get
		{
			if (instance == null)
				instance = new GameState();
			return instance;
		}
	}
	
	private GameState()
	{
		drawPile.initialDrawDeck();
	}
    // ****************************************
	
	public Deck drawPile = new Deck();

	public Deck oponentHand = new Deck();
	public Deck playerHand = new Deck();

	public Deck playerTable = new Deck();
	public Deck openentTable = new Deck();

	public Deck discardPile = new Deck();

	public void drawCard(PlayerType player) {
		if(player == PlayerType.PLAYER){
			playerHand.addCard(drawPile.removeTopCard());
		} else {
			oponentHand.addCard(drawPile.removeTopCard());
		}
	}

	public void transferCardFromDecks(Deck fromDeck, Deck toDeck, Card card) {
		toDeck.addCard(fromDeck.removeCard(card));
	}

}
