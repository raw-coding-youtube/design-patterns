<Query Kind="Program" />

void Main()
{

}

interface Command
{
	void Execute();
}

public class HighlightConfig
{
	public int Colour { get; set; }
	public int Height { get; set; }
} 

class HighlightText : Command
{

	// text is the reciever
	// config is some singleton holding the state of the colour tool
	public HighlightText(string text, HighlightConfig config)
	{

	}

	public void Execute()
	{
		// highlight text range
	}
}

class BoldText : Command
{
	// text is the reciever
	public BoldText(string text)
	{

	}

	public void Execute()
	{
		// make text range bold
	}
}

// button is the the decoupling
// we don't know about the operation or the reciever
class Button
{
	Command command;
	public Button(Command command) => this.command = command;

	public void Click() => command.Execute();
}