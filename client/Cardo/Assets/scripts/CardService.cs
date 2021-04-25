using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class CardService
{
	// INSTANTIATES CARDSERVICE AS A SINGLETON
	private static CardService instance = null;
	public static CardService GetInstance
	{
		get
		{
			if (instance == null)
				instance = new CardService();
			return instance;
		}
	}
	
	private CardService()
	{
	}
    // ****************************************

    public string getCardText(int cardNumber){
		string returnText = "";
		int number = (cardNumber % 13) + 1;
		switch (number)
		{	
			case 1:
				returnText = CardText.ACE;
				break;
			case 2:
				returnText =  CardText.TWO;
				break;
			case 3:
				returnText =  CardText.THREE;
				break;
			case 4:
				returnText =  CardText.FOUR;
				break;
			case 5:
				returnText =  CardText.FIVE;
				break;
			case 6:
				returnText =  CardText.SIX;
				break;
			case 7:
				returnText =  CardText.SEVEN;
				break;
			case 8:
				returnText =  CardText.EIGHT;
				break;
			case 9:
				returnText =  CardText.NINE;
				break;
			case 10:
				returnText =  CardText.TEN;
				break;
			case 11:
				returnText =  CardText.JACK;
				break;
			case 12:
				returnText =  CardText.QUEEN;
				break;	
			case 13:
				returnText =  CardText.KING;
				break;	
            default:
                returnText =  "";
				break;
		}

		return addLineBreak(returnText);
    }

	public string addLineBreak(string text) {
		string newText = "";
		for (int i = 0; i < text.Length; i++)
		{
			newText += text[i];
			if((i+1)%24 == 0) {
				if(text[i] != ' '){
					newText += '-';
				}
				newText += '\n';
				
			}
		}
		return newText;
	}
}