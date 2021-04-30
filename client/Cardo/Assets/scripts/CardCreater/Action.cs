using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Action", menuName = "Action", order = 1)]
public class Action : ScriptableObject
{
    public string action;
    public AbilityType ability;

 
    public PlayerType playerTurn;

    [DrawIf("ability", AbilityType.DRAW, ComparisonType.Equals, DisablingType.DontDraw)]
    public int numberOfCardsToDraw;

    [DrawIf("ability", AbilityType.SELECT, ComparisonType.Equals, DisablingType.DontDraw)]
    public int numberOfCardsToSelect;

    public Deck cards;

}

public enum AbilityType {
    TRANSFER,
    DRAW,
    SELECT,
    BLOCK,
    SHOW_CARDS,
    HIDE_CARDS,
    REDUCE_VICTORY_POINTS

};

public enum PlayerType{
    PLAYER,
    OPPONENT
}

public enum CardType {
    ATTACK,
    DEFENSE,
    EFFECT
}
