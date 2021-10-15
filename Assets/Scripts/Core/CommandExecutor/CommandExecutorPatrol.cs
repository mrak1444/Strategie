using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CommandExecutorPatrol : CommandExecutorBase<IPatrolCommand>
{
    public override async Task ExecuteSpecificCommand(IPatrolCommand command)
    {
        await Task.Run(() => Message(command));
    }

    private void Message(IPatrolCommand command)
    {
        Debug.Log($"{name} moves from {transform.position} to {command.To}");
    }
}
