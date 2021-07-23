using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Flags", menuName = "Actions/Flags", order = 1)]
public class FlagsScriptable : ScriptableObject
{
    public List<string> flags;
}
