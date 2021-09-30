using UnityEngine;

public class CommandExecutorMove : CommandExecutorBase<IMoveCommand>
{
    public override void ExecuteSpecificCommand(IMoveCommand command)
    {
        Debug.Log($"{name} - Move");
    }
}
