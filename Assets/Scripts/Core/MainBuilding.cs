using System.Threading.Tasks;
using UnityEngine;

public class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable, IAttackable
{
	public float Health
	{
		get
		{
			return _health;

		}
		set
		{
			_health -= value;
		}
	}
	public float MaxHealth => _maxHealth;
	public Sprite Icon => _icon;

    public Transform PivotPoint => transform;

    [SerializeField] private Transform _unitsParent;

	[SerializeField] private float _maxHealth = 1000;
	[SerializeField] private Sprite _icon;

	private float _health = 1000;

	public override async Task ExecuteSpecificCommand(IProduceUnitCommand command)
	{
		await Task.Run(() => Instant(command));
	}

	private void Instant(IProduceUnitCommand command)
    {
		Instantiate(command.UnitPrefab, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
	}
}
