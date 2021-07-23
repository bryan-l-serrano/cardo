using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionType {
    TRANSFER,
    DRAW,
    SELECT,
    //REPLACE THESE WITH SET/REMOVE FLAGS
    // BLOCK,
    // SHOW_CARDS,
    // HIDE_CARDS,
    COUNTER_CHANGE,
    SET_FLAGS,
    REMOVE_FLAGS,
    STORE_DECK, //STORE A DECK BASED ON CRITERIA SUCH AS FLAGS OR DECK INTERSECTIONS
    USE_CARD_ABILITY,
    END_TURN 
};

public enum AuxilaryTriggers {
    CLICK_OBJECT,
    EXIT_ACTION,
    START_PLAYER_TURN,
    END_PLAYER_TURN
}
public enum PlayerType{
    PLAYER1,
    PLAYER2
}

public enum GameStateDecks{
    PLAYER_HAND,
    OPPONENT_HAND,
    DRAW_PILE,
    DISCARD_PILE,
    STORED_DECK
    
}

public enum CardFlag {
    ATTACK,
    DEFENSE,
    EFFECT,
    POINT,
    SELECTABLE,
    IN_HAND,
    BLOCKED,
    HIDDEN
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
