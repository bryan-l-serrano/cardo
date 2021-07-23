using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Deck {

    public List<Card> deck;

    public Deck() {
        deck = new List<Card>();
    }

    public void initialDrawDeck() {
		// Adds the basic cards to the deck
		List<Card> cardArray = new List<Card>();
		for (int i = 0; i < 52; i++)
		{
			Card card = new Card(i);

			cardArray.Add(card);
		}

		this.deck = shuffleArray(cardArray);	
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

    public List<Card> getDeck(){
        return this.deck;
    }

    public Card removeTopCard(){
        Card topCard = this.deck[0];
        this.deck.Remove(topCard);
        Debug.Log("Number of Cards After Removal:" + this.deck.Count);
        return topCard;
    }

    public Card removeCard(Card card){
        this.deck.Remove(card);
        return card;
    }

    public void addCard(Card card) {
        this.deck.Add(card);
    }

    public string getStringOfCards(){
        string deckString = "";
        foreach (var card in deck)
        {
            deckString += card.ToString() + ", ";
        }
        return deckString;
    }
}