using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState {
	
	public Deck drawPile = new Deck();

	public Deck oponentHand = new Deck();
	public Deck playerHand = new Deck();

	public Deck playerTable = new Deck();
	public Deck openentTable = new Deck();

	public Deck discardPile = new Deck();

	public GameState() {
		drawPile.initialDrawDeck();
	}

	public void drawCard(bool isPlayer) {
		if(isPlayer){
			playerHand.addCard(drawPile.removeTopCard());
		} else {
			oponentHand.addCard(drawPile.removeTopCard());
		}
	}

	public void transferCardFromDecks(Deck fromDeck, Deck toDeck, Card card) {
		toDeck.addCard(fromDeck.removeCard(card));
	}

}
