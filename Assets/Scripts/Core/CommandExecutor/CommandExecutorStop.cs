using System.Threading;
using System.Threading.Tasks;

public class CommandExecutorStop : CommandExecutorBase<IStopCommand>
{
	public CancellationTokenSource CancellationTokenSource { get; set; }

	public override async Task ExecuteSpecificCommand(IStopCommand command)
	{
		await Task.Run(() => Cancel(command));
	}

	private void Cancel(IStopCommand command)
    {
		CancellationTokenSource?.Cancel();
	}
}
