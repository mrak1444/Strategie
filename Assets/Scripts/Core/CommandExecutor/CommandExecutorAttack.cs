using UnityEngine;

public class CommandExecutorAttack : CommandExecutorBase<IAttackCommand>
{
    public override void ExecuteSpecificCommand(IAttackCommand command)
    {
        Debug.Log($"{name} - Attack");
    }
}