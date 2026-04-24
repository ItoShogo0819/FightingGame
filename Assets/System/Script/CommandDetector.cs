using UnityEngine;
using System.Collections.Generic;
using System;

public class CommandDetector : MonoBehaviour
{
    public event Action<CommandDefinitionSO> OnCommandDetected;



    private readonly InputBuffer _inputBuffer;
    private readonly List<CommandDefinitionSO> _commands;
    private bool _facingRight = true;
}
