using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardAbility", menuName = "CardAbility", order = 1)]
public class CardAbilityFlow : ScriptableObject
{
    public List<Action> actions;
}

