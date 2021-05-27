using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card : MonoBehaviour {

	public int cardNumber;
	public string cardName;

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

}
