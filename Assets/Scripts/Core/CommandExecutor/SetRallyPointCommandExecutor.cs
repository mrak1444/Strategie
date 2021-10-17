using System.Threading.Tasks;

public class SetRallyPointCommandExecutor : CommandExecutorBase<ISetRallyPointCommand>
{
	public override async Task ExecuteSpecificCommand(ISetRallyPointCommand command)
	{
		await Task.Run(() => SetRallyPoint(command));
	}

	private void SetRallyPoint(ISetRallyPointCommand command)
    {
		GetComponent<MainBuilding>().RallyPoint = command.RallyPoint;
	}
}