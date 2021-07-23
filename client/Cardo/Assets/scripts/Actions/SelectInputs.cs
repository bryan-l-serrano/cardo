using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectInputs
{
    //SINGLETON *****************************
	private static SelectInputs instance = null;
	public static SelectInputs GetInstance
	{
		get
		{
			if (instance == null)
				instance = new SelectInputs();
			return instance;
		}
	}
	
	private SelectInputs()
	{
        selectableCards = new List<CardFlag>();
        nonSelectableCards = new List<CardFlag>();
	}
    // ****************************************

    // SELECT INPUTS
    public int numberOfSelectableCards;
    public List<CardFlag> selectableCards;
    public List<CardFlag> nonSelectableCards;
    //*****************************************

    // SELECT OUTPUTS**************************
    public Deck selectedCards;
    //*****************************************

    public void clearOutputs(){
        selectedCards = new Deck();
    }

    
    //INPUT: cardFlagsToCheckAgainst - these are the flags that exist on the card
    //LOGIC: isSelectableCard() checks the flags that we've deemed selectable or nonselectable against
    //       the flags on the card.
    //RETURN: isValidCard - returns if the card is selectable or not.
	public bool isSelectableCard(List<CardFlag> cardFlagsToCheckAgainst){
        bool isValidCard = true;
        if(selectableCards.Count>0){
            foreach (var flag in selectableCards)
            {
               if(!cardFlagsToCheckAgainst.Contains(flag))
               {
                   isValidCard = false;
                   break;
               }
            }
        }

        if(isValidCard && nonSelectableCards.Count>0){
            foreach (var flag in nonSelectableCards)
            {
                if(cardFlagsToCheckAgainst.Contains(flag)){
                    isValidCard = false;
                }
            }
        }
        return isValidCard;
    }

    public void addToSelectedCards(Card card){
        Debug.Log("CARD ADDED--------------------------");
        Debug.Log(selectedCards.getStringOfCards());
        selectedCards.addCard(card);
        Debug.Log(selectedCards.getStringOfCards());

    }

    public bool maxCardsReached() {
        return selectedCards.getDeck().Count > numberOfSelectableCards;
    }

}