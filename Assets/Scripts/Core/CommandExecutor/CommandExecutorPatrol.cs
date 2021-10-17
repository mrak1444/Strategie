using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CommandExecutorPatrol : CommandExecutorBase<IPatrolCommand>
{
    public override async Task ExecuteSpecificCommand(IPatrolCommand command)
    {
        await Task.Run(() => Patrol(command));
    }

    private void Patrol(IPatrolCommand command)
    {
        Debug.Log($"{name} moves from {transform.position} to {command.To}");
    }
}
