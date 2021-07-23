using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Card : MonoBehaviour{

	public int cardNumber;
	public string cardName;
	public List<Action> ability;

	public List<CardFlag> cardFlags;

	//public CardAbilitiesFlow cardAbilities;

	public Card(int cardNumber) {
		this.cardNumber = cardNumber;
		cardFlags = new List<CardFlag>();
		cardFlags.Add(CardFlag.POINT);
	}

	public Card(string cardName) {
		this.cardName = cardName;
	}

	public void triggerAbility(){
		//cardAbilities = new CardAbilities();
		//cardAbilities.triggerAbility(this.cardNumber);
    }

	public override string ToString() {
		return cardNumber.ToString();
	}

	public override bool Equals(object obj)
   	{
      //Check for null and compare run-time types.
      if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
      {
         return false;
      }
      else {
         Card p = (Card) obj;
         return (cardNumber == p.cardNumber) && (cardName == p.cardName);
      }
  	}

	public override int GetHashCode()
   	{
      return 0;
  	}

}
