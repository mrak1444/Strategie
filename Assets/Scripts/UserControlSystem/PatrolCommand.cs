using UnityEngine;

public class PatrolCommand : IPatrolCommand
{
    public Vector3 To { get; }

    public PatrolCommand(Vector3 to)
    {
        To = to;
    }
}
