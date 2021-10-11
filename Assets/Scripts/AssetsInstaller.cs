using System;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "AssetsInstaller", menuName = "Installers/AssetsInstaller")]
public class AssetsInstaller : ScriptableObjectInstaller<AssetsInstaller>
{
    [SerializeField] private AssetsContext _legacyContext;
    [SerializeField] private Vector3Value _vector3Value;
    [SerializeField] private SelectableValue _selectableValue;
    [SerializeField] private AttackableValue _attackableClicksRMB;

    public override void InstallBindings()
    {
        Container.Bind<IAwaitable<IAttackable>>().FromInstance(_attackableClicksRMB);
        Container.Bind<IAwaitable<Vector3>>().FromInstance(_vector3Value);
        Container.BindInstances(_legacyContext, _vector3Value, _selectableValue);
        Container.Bind<IObservable<ISelectable>>().FromInstance(_selectableValue);
    }
}