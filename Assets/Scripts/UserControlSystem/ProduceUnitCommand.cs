using UnityEngine;

public class ProduceUnitCommand : IProduceUnitCommand
{
	public GameObject UnitPrefab => _unitPrefab;
	[InjectAsset("Chomper")] private GameObject _unitPrefab;
}