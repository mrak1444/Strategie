using UnityEngine;

public class MainBuilding : MonoBehaviour, ISelectable, IAttackable
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
	[SerializeField] private Vector3 _rallyPoint;

	private float _health = 1000;

	public Vector3 RallyPoint 
	{
		get 
		{
			return _rallyPoint;
		}
        set
        {
			_rallyPoint = value;
        }
	}

	public void RecieveDamage(int amount)
	{
		if (_health <= 0)
		{
			return;
		}
		_health -= amount;
		if (_health <= 0)
		{
			Destroy(gameObject);
		}
	}
}
