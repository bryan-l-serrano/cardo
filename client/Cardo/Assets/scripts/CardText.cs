using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class CardText {

    public const string ACE = "Put all point cards on the table into the scrap pile.";
    public const string TWO = "Place any card on the table into the scrap pile, except a point card. " + 
        "(In practice, Kings, Queens, Jacks and the \"glasses\" eight) or Place any one-off just played into the scrap pile. " + 
        "This occurs before the effect of that card is accomplished, and, uniquely, can be played during the opponents turn, as well as your own.";

    public const string THREE = "Rummage through the scrap pile, taking a card of your choice into your hand.";
    public const string FOUR = "Opponent must discard two cards of his choice from his hand and you take one of those of your choice.";
    public const string FIVE = "You may draw three cards.";
    public const string SIX = "All cards on the table except for point cards are moved into the scrap pile.";
    public const string SEVEN = "Draw two cards. You can and must play this drawn card's ability immediately. " + 
        "-10's ive your oppenent 1 card, " +
        "7's add two more cards to draw and play immediately" +
        "if queen is drawn while the player has a queen, draw 3 cards";
    public const string EIGHT = "As well as a point card, an eight too has a secondary use, although it is not a one-off. " + 
        "Instead, the card may be placed rather like a King or Queen, but at right angles to the opponent " + 
        "(and his other cards). This differentiates it from point card eights, and simultaneously makes it " + 
        "look like a pair of glasses! The effect is that the opponent must play with his hand exposed until " + 
        "he finds a way to transfer the eight to the scrap pile.";
    public const string NINE = "Steal a royal from the opponent. must steal queen first if opponent has a queen in play.";
    public const string TEN = "10 points, opponent draws a card.";
    public const string JACK = "Placed on top of a point card (A-10) already on the table. " +
        "Kept there, the card is moved across the table and is now owned by the opponent of its original owner (who is generally your opponent!)";
    public const string QUEEN = "Played on the table, like a point card. With a Queen in play, " + 
        "none of your other cards may be the target of opposing cards that target a single card. " + 
        "(Specifically: **Jacks, twos, and nines**). However, this offers no protection against those like " + 
        "aces that target more widely, even if there is only one card the table that will be affected. " + 
        "Nor do Queens offer any protection against scuttle attacks." +
	    "* a queen becomes a draw three card if you already have a queen in play";

    public const string KING = "Played like Queens. With a King in play, a player can win with just 20 points worth " + 
        "of point cards on the table. With two Kings he needs just 16, with three, 13, and with all four 11 points!";
}