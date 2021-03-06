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
		Debug.Log("INITIALIZING DECKS-----------------------------------------");
		drawPile = new Deck();
		player1Hand = new Deck();
		player2Hand = new Deck();

		player1Table = new Deck();
		player2Table = new Deck();

		discardPile = new Deck();

		drawPile.initialDrawDeck();
		Debug.Log("END INITIALIZING------------------------------------------");
	}
    // ****************************************
	
	//DECKS************************************

	public Deck drawPile;

	public Deck player1Hand;
	public Deck player2Hand;

	public Deck player1Table;
	public Deck player2Table;

	public Deck discardPile;
	//END DECKS********************************

	//STATE VARIABLES**************************

	// This sets which card ability is currently active.
	public SelectedCardAbility selectedCardAbility = SelectedCardAbility.NONE;

	// This sets which player is currently active
	public PlayerType playersTurn;

	//END STATE VARIABLES*********************

	public Card drawCard(PlayerType player) {
		Debug.Log("Card Drawn-------------------------------------");
		Card drawnCard = drawPile.removeTopCard();
		Debug.Log(drawnCard);
		Debug.Log("-----------------------------------------------");
		if(player == PlayerType.PLAYER1){
			player1Hand.addCard(drawnCard);
		} else {
			player2Hand.addCard(drawnCard);
		}
		return drawnCard;
	}

	public void transferCardFromDecks(Deck fromDeck, Deck toDeck, Card card) {
		toDeck.addCard(fromDeck.removeCard(card));
	}

}
