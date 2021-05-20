<Query Kind="Program" />

void Main()
{
	var process = new Process();
	process.Setup(p =>
	{
		// ad hoc strategy
	});
}

public class Process {
	public void Setup(Action<Process> setup) => setup(this);
}
