using UnityEngine;

public class MainUnit : MonoBehaviour, ISelectable, IAttackable
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

    [SerializeField] private float _maxHealth = 100;
	[SerializeField] private Sprite _icon;

	private float _health = 100;
}