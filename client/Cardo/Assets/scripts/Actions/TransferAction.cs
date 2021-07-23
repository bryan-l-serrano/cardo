using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferAction
{
    //SINGLETON *****************************
	private static TransferAction instance = null;
	public static TransferAction GetInstance
	{
		get
		{
			if (instance == null)
				instance = new TransferAction();
			return instance;
		}
	}

	private TransferAction()
	{
        transferFromDeck = new Deck();
        transferToDeck = new Deck();

        gameState = GameState.GetInstance;
	}
    //****************************************

    //This is the deck that the cards are being removed from
    public Deck transferFromDeck;
    //This is the deck that the cards are being added to
    public Deck transferToDeck;
    //These are the cards being tranfered between the two decks
    public Deck deckToBeTransfered;

    private GameState gameState;

    public void transferCards() {
        Debug.Log("BEFORE***********************************");
        Debug.Log(transferToDeck.getStringOfCards());
        Debug.Log(transferFromDeck.getStringOfCards());
        Debug.Log("********************************************");
        foreach (var card in deckToBeTransfered.getDeck())
        {
            gameState.transferCardFromDecks(transferFromDeck, transferToDeck, card);
        }
        Debug.Log("AFTER***********************************");
        Debug.Log(transferToDeck.getStringOfCards());
        Debug.Log(transferFromDeck.getStringOfCards());
        Debug.Log("********************************************");
    }

    public void setTransferInputs(Deck fromDeck, Deck toDeck, Deck transferCards) {
        transferFromDeck = fromDeck;
        transferToDeck = toDeck;
        deckToBeTransfered = transferCards;
    }


    public Deck debugTo(){
        Deck toDeck = new Deck();
        toDeck.addCard(new Card(4));
        toDeck.addCard(new Card(19));
        return toDeck;
    }

    public Deck debugFrom(){
        Deck fromDeck = new Deck();
        fromDeck.addCard(new Card(1));
        fromDeck.addCard(new Card(20));
        return fromDeck;
    }

    public Deck debugTransfer(){
        Deck toDeck = new Deck();
        toDeck.addCard(new Card(1));
        return toDeck;
    }

}