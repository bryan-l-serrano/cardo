using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionType {
    TRANSFER,
    DRAW,
    DISCARD,
    SELECT,
    BLOCK,
    SHOW_CARDS,
    HIDE_CARDS,
    COUNTER_INCREASE

};

public enum PlayerType{
    PLAYER1,
    PLAYER2
}

public enum CardType {
    ATTACK,
    DEFENSE,
    EFFECT
}

public enum SelectedCardAbility {
    NONE,
    ACE,
    ONE,
    TWO,
    THREE,
    FOUR,
    FIVE,
    SIX,
    SEVEN,
    EIGHT,
    NINE,
    TEN,
    JACK,
    QUEEN,
    KING,
}
