using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO Make this class a Singleton
public class CardAbilities
{
		// INSTANTIATES AS A SINGLETON
	private static CardAbilities instance = null;
	public static CardAbilities GetInstance
	{
		get
		{
			if (instance == null)
				instance = new CardAbilities();
			return instance;
		}
	}
	
	private CardAbilities()
	{
	}
    // ****************************************
	GameState gameState = GameState.GetInstance;
    public void triggerAbility(int cardNumber){
		int number = (cardNumber % 13) + 1;
		switch (number)
		{	
			case 1:
				ace();
				break;
			case 2:
				two();
				break;
			case 3:
				three();
				break;
			case 4:
				four();
				break;
			case 5:
				five();
				break;
			case 6:
				six();
				break;
			case 7:
				seven();
				break;
			case 8:
				eight();
				break;
			case 9:
				nine();
				break;
			case 10:
				ten();
				break;
			case 11:
				jack();
				break;
			case 12:
				queen();
				break;	
			case 13:
				king();
				break;	
		}
    }
    //TODO Fill these in with abilities
    private void ace() {
        Debug.Log("Played the ace");
    }
    private void two() {
        Debug.Log("Played the two");
    }
    private void three() {
		this.gameState.selectedCardAbility = SelectedCardAbility.THREE;
    }
    private void four() {
        Debug.Log("Played the four");
    }
    private void five() {
        Debug.Log("Played the five");
    }
    private void six() {
        Debug.Log("Played the six");
    }
    private void seven() {
        Debug.Log("Played the seven");
    }
    private void eight() {
        Debug.Log("Played the eight");
    }
    private void nine() {
        Debug.Log("Played the nine");
    }
    private void ten() {
        Debug.Log("Played the ten");
    }
    private void jack() {
        Debug.Log("Played the jack");
    }
    private void queen() {
        Debug.Log("Played the queen");
    }
    private void king() {
        Debug.Log("Played the king");
    }

    

}