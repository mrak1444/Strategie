using System.Threading.Tasks;

public interface ICommandExecutor
{
    void ExecuteCommand(object command);
}

public interface ICommandExecutor<T> : ICommandExecutor where T : ICommand
{
}
