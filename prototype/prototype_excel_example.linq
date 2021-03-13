<Query Kind="Program" />

void Main()
{
	List<IBlock> grid = new List<IBlock>();
	grid.Add(BlockFactory.Create("Hello World"));
	grid.Add(BlockFactory.Create("3"));
	grid.Add(BlockFactory.Create("11/02/1980"));
	grid.Dump();
	
	var block3 = (DateTimeBlock)grid[2].Clone();
	block3.Format = "MM/dd/yyyy";
	grid.Add(block3);

	var block4 = (DateTimeBlock)grid[3].Clone();
	block4.DateTime = DateTime.UtcNow;
	grid.Add(block4);
	grid.Dump();
}

public class BlockFactory
{
	public static IBlock Create(string content)
	{
		if (DateTime.TryParse(content, out var dt))
			return new DateTimeBlock()
			{
				Format = "dd/MM/yyyy",
				DateTime = dt
			};

		if (int.TryParse(content, out var n))
			return new NumberBlock() { Number = n };

		return new TextBlock { Content = content };
	}
}

public interface IBlock
{
	string Render { get; }
	IBlock Clone();
}

public class TextBlock : IBlock
{
	public string Content { get; set; }
	public IBlock Clone() => new TextBlock { Content = Content };

	public string Render => Content;
}

public class NumberBlock : IBlock
{
	public int Number { get; set; }
	public IBlock Clone() => new NumberBlock { Number = Number };

	public string Render => Number.ToString();
}

public class DateTimeBlock : IBlock
{
	public DateTime DateTime { get; set; }
	public string Format { get; set; }
	public IBlock Clone() => new DateTimeBlock
	{
		Format = Format,
		DateTime = DateTime
	};

	public string Render => DateTime.ToString(Format);
}