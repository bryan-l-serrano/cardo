using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardScriptable", menuName = "Actions/Card", order = 1)]
public class CardScriptable : ScriptableObject
{
    public string cardName;
    public int numberOfCardsInDeck;
    public List<string> flags;
}
