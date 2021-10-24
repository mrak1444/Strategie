using UnityEngine;
using Zenject;

public class ProduceUnitCommandEllen : IProduceUnitCommand
{
	[Inject(Id = "Chomper")] public string UnitName { get; }
	[Inject(Id = "Chomper")] public Sprite Icon { get; }
	[Inject(Id = "Chomper")] public float ProductionTime { get; }

	public GameObject UnitPrefab => _unitPrefab;
	[InjectAsset("Ellen")] private GameObject _unitPrefab;
}