using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandExecutorPatrol : CommandExecutorBase<IPatrolCommand>
{
    public override void ExecuteSpecificCommand(IPatrolCommand command)
    {
        Debug.Log($"{name} moves from {transform.position} to {command.To}");
    }
}
