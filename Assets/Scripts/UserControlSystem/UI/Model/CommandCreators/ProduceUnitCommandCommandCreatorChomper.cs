using System;
using Zenject;

public class ProduceUnitCommandCommandCreatorChomper : CommandCreatorBase<IProduceUnitCommand>
{
	[Inject] private AssetsContext _context;
	[Inject] private DiContainer _diContainer;

	protected override void classSpecificCommandCreation(Action<IProduceUnitCommand> creationCallback)
	{
		var produceUnitCommand = _context.Inject(new ProduceUnitCommandChomper());
		_diContainer.Inject(produceUnitCommand);
		creationCallback?.Invoke(produceUnitCommand);
	}
}