public class AttackCommand : IAttackCommand
{
    public IAttackable SelecAttack { get; }

    public AttackCommand(IAttackable selecAttack)
    {
        SelecAttack = selecAttack;
    }
}
