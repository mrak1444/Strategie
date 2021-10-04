public class AttackCommand : IAttackCommand
{
    public ISelectable SelecAttack { get; }

    public AttackCommand(ISelectable selecAttack)
    {
        SelecAttack = selecAttack;
    }
}
