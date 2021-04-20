<Query Kind="Program" />

void Main()
{
	var textContext = new TextContext();
	var c1 = new DynamicCommand<TextContext>(textContext, tc => tc.HighlightText());
	var c2 = new DynamicCommand<TextContext>(textContext, tc => tc.BoldText());
	
	// via reflection:
	// typeof(TextContext).GetMethod("HighlightText").Invoke(textContext, null);
}

public class HighlightConfig
{
	public int Colour { get; set; }
	public int Height { get; set; }
}

public class TextContext
{
	public void HighlightText()
	{

		// highlight text range
	}

	public void BoldText()
	{
		// make text range bold
	}
}


interface ICommand
{
	void Execute();
}


class DynamicCommand<T> : ICommand
{
	T reciever;
	Action<T> action;
	public DynamicCommand(T reciever, Action<T> action)
	{
		this.reciever = reciever;
		this.action = action;
	}

	public void Execute()
	{
		action(reciever);
	}
}


// button is the the decoupling
// we don't know about the operation or the reciever
class Button
{
	ICommand command;
	public Button(ICommand command) => this.command = command;

	public void Click() => command.Execute();
}