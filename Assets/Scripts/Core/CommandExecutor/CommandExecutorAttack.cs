using System.Threading.Tasks;
using UnityEngine;

public class CommandExecutorAttack : CommandExecutorBase<IAttackCommand>
{
    public override async Task ExecuteSpecificCommand(IAttackCommand command)
    {
        
        await Task.Run(() => Attack(command));
    }

    private void Attack(IAttackCommand command)
    {
        command.SelecAttack.Health = 10;
        Debug.Log($"{name} inflict 10 points of damage!");
    }
}