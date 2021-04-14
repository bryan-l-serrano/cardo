using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card {

	public int cardNumber;
	public string cardName;

	CardAbilities cardAbilities;

	public Card(int cardNumber) {
		this.cardNumber = cardNumber;
	}

	public Card(string cardName) {
		this.cardName = cardName;
	}

	public void triggerAbility(){
		cardAbilities = new CardAbilities();
		cardAbilities.triggerAbility(this.cardNumber);
    }

	public string ToString() {
		return cardNumber.ToString();
	}
}
