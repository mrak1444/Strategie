using System;
using Zenject;

public class ProduceUnitCommandCommandCreatorEllen : CommandCreatorBase<IProduceUnitCommand>
{
	[Inject] private AssetsContext _context;
	[Inject] private DiContainer _diContainer;

	protected override void classSpecificCommandCreation(Action<IProduceUnitCommand> creationCallback)
	{
		var produceUnitCommand = _context.Inject(new ProduceUnitCommandEllen());
		_diContainer.Inject(produceUnitCommand);
		creationCallback?.Invoke(produceUnitCommand);
	}
}