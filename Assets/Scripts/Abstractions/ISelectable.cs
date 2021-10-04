using UnityEngine;

public interface ISelectable
{
	float Health { get; set; }
	float MaxHealth { get; }
	Sprite Icon { get; }
}