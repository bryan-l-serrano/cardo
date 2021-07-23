using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesService
{


    public void checkForPoints(Card card) {
        if(card.cardFlags.Contains(CardFlag.POINT)) {
            //TODO trigger the action that lets people choose to add points or trigger the abilities
        }
    }

    public void triggerAbility(Card card) {
        List<Action> actions = card.ability;

        foreach (var act in actions)
        {
            
        }
    }
}