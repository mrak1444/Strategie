using System;

public abstract class CommandCreatorBase<T> where T : ICommand
{
    public ICommandExecutor ProcessCommandExecutor(ICommandExecutor commandExecutor, Action<T> callback)
    {
        if (commandExecutor is ICommandExecutor<T> classSpecificExecutor)
        {
            classSpecificCommandCreation(callback);
        }
        return commandExecutor;
    }

    protected abstract void classSpecificCommandCreation(Action<T> creationCallback);

    public virtual void ProcessCancel() { }
}