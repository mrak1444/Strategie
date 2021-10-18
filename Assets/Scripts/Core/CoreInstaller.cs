using UnityEngine;
using Zenject;

public class CoreInstaller : MonoInstaller
{
	[SerializeField] private IGameStatus _gameStatus;
	public override void InstallBindings()
	{
		Container.BindInterfacesAndSelfTo<TimeModel>().AsSingle();
		Container.Bind<IGameStatus>().FromInstance(_gameStatus);
	}
}