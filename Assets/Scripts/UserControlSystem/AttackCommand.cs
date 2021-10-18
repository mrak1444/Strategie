public class AttackCommand : IAttackCommand
{
    public IAttackable Target { get; }

    public AttackCommand(IAttackable selecAttack)
    {
        Target = selecAttack;
    }
}
