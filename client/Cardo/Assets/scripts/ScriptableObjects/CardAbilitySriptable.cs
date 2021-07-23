using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Action", menuName = "Actions/Ability", order = 1)]
public class CardAbilitySriptable : ScriptableObject
{
    public List<Action> actions;
}
