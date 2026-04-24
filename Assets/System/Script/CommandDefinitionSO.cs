using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "FightingGame/CommandDefinition")]
public class CommandDefinitionSO : ScriptableObject
{
    public string commandName;
    public List<NumpadDirection> sequence;
    public int InputWindowames = 15;
}
