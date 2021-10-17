using System.Threading;
using System.Threading.Tasks;

public class CommandExecutorStop : CommandExecutorBase<IStopCommand>
{
	public CancellationTokenSource CancellationTokenSource { get; set; }

	public override async Task ExecuteSpecificCommand(IStopCommand command)
	{
		await Task.Run(() => Stop(command));
	}

	private void Stop(IStopCommand command)
    {
		CancellationTokenSource?.Cancel();
	}
}
