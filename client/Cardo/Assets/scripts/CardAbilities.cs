using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO Make this class a Singleton
public class CardAbilities
{
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
    public void ace() {
        Debug.Log("Played the ace");
    }
    public void two() {
        Debug.Log("Played the two");
    }
    public void three() {
        Debug.Log("Played the three");
    }
    public void four() {
        Debug.Log("Played the four");
    }
    public void five() {
        Debug.Log("Played the five");
    }
    public void six() {
        Debug.Log("Played the six");
    }
    public void seven() {
        Debug.Log("Played the seven");
    }
    public void eight() {
        Debug.Log("Played the eight");
    }
    public void nine() {
        Debug.Log("Played the nine");
    }
    public void ten() {
        Debug.Log("Played the ten");
    }
    public void jack() {
        Debug.Log("Played the jack");
    }
    public void queen() {
        Debug.Log("Played the queen");
    }
    public void king() {
        Debug.Log("Played the king");
    }

    

}