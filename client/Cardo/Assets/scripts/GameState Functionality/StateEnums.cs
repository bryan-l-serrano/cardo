using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionType {
    TRANSFER,
    DRAW,
    DISCARD,
    SELECT,
    //REPLACE THESE WITH SET FLAGS
    // BLOCK,
    // SHOW_CARDS,
    HIDE_CARDS,
    COUNTER_INCREASE,
    SET_FLAGS
};

public enum PlayerType{
    PLAYER1,
    PLAYER2
}

public enum CardFlag {
    ATTACK,
    DEFENSE,
    EFFECT,
    POINT,
    SELECTABLE,
    IN_HAND,
    BLOCKED,
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
