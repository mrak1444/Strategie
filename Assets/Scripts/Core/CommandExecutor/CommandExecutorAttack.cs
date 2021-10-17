using System.Threading.Tasks;
using UnityEngine;

public class CommandExecutorAttack : CommandExecutorBase<IAttackCommand>
{
    public override async Task ExecuteSpecificCommand(IAttackCommand command)
    {
        await Task.Run(() => Health(command));
    }

    private void Health(IAttackCommand command)
    {
        //command.SelecAttack.Health = 10;
    }
}