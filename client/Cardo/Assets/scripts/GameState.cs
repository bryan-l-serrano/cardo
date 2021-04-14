using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState {
	
	public List<Card> drawPile = new List<Card>();

	public List<Card> oponentHand = new List<Card>();
	public List<Card> playerHand = new List<Card>();

	public List<Card> playerTable = new List<Card>();
	public List<Card> openentTable = new List<Card>();

	public List<Card> discardPile = new List<Card>();

	public GameState() {
		drawPile = InitialDrawDeck();
	}

	public List<Card> InitialDrawDeck() {
		// Adds the basic cards to the deck
		List<Card> cardArray = new List<Card>();
		for (int i = 0; i < 52; i++)
		{
			Card card = new Card(i);

			cardArray.Add(card);
		}

		return shuffleArray(cardArray);	
	}

	public List<Card> shuffleArray(List<Card> array) {
		System.Random random = new System.Random();
		for (int i = array.Count-1; i > 0; i--)
		{
			int randomIndex = random.Next(0, i);
			Card temp = array[i];
			array[i] = array[randomIndex];
			array[randomIndex] = temp;
		}
		return array;
	}

	public void drawCard(bool isPlayer) {
		Card topCard = drawPile[drawPile.Count-1];
		drawPile.Remove(topCard);
		if(isPlayer){
			playerHand.Add(topCard);
		} else {
			oponentHand.Add(topCard);
		}
	}

	public void playCard(Card card, bool isPlayer) {
		if(isPlayer) {
			card.triggerAbility();
			playerTable.Add(card);
			playerHand.Remove(card);
		}
	}

}
