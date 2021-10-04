using UnityEngine;

public class CommandExecutorAttack : CommandExecutorBase<IAttackCommand>
{
    public override void ExecuteSpecificCommand(IAttackCommand command)
    {
        command.SelecAttack.Health = 10;
        Debug.Log($"{name} inflict 10 points of damage!");
    }
}