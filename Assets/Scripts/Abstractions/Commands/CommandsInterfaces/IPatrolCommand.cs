using UnityEngine;

public interface IPatrolCommand : ICommand
{
    public Vector3 To { get; }
}
