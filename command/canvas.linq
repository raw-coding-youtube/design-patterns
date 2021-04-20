<Query Kind="Program" />

void Main()
{

}
public class Canvas
{

}

public interface Command
{
	void Execute(Canvas canvas);
}

public class Tool
{
	static string state;

	public static Command GetCommand()
	{
		if (state == "brush")
			return new Brush();
		if (state == "erase")
			return new Erase();
		if (state == "fill")
			return new Fill();

		return null;
	}
}

public class Brush : Command
{
	public void Execute(Canvas canvas)
	{
		// perform action on the canvas
	}
}

public class Erase : Command
{
	public void Execute(Canvas canvas)
	{
		// perform action on the canvas
	}
}

public class Fill : Command
{
	public void Execute(Canvas canvas)
	{
		// perform action on the canvas
	}
}



Canvas canvas;

public void Click()
{
	Tool.GetCommand().Execute(canvas);
}