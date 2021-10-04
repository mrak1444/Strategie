using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "AssetsInstaller", menuName = "Installers/AssetsInstaller")]
public class AssetsInstaller : ScriptableObjectInstaller<AssetsInstaller>
{
    [SerializeField] private AssetsContext _legacyContext;
    [SerializeField] private Vector3Value _vector3Value;
    [SerializeField] private SelectableValue _selectableValue;

    public override void InstallBindings()
    {
        Container.BindInstances(_legacyContext, _vector3Value, _selectableValue);
    }
}