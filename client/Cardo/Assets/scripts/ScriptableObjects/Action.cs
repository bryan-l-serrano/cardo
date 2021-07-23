using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Action", menuName = "Actions/Action", order = 1)]
public class Action: ScriptableObject
{
    public ActionType actionType;
    public List<int> intInputs;
    public List<string> cardNameInputs;
    public List<GameStateDecks> gameStateDeckInputs;

    public List<string> stringInputs;
    public List<string> cardFlagInputs;
    public bool opponentAction;

    public bool isBlockableAction;
    public List<string> cardsThatOpponentCanPlayThatBlockAction;
    public bool doesBlockingActionEndPlayerTurn; 
}