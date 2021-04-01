<Query Kind="Program" />

void Main()
{
	new Table().Dump();
}

public abstract class Product
{
	public List<Product> Components { get; set; } = new List<Product>();
}

public class Table : Product
{
	public Table()
	{
		Components.Add(new Legs());
		Components.Add(new Top());
		Components.Add(new Screws());
	}
}

public class Top : Product { }

public class Legs : Product
{
	public Legs()
	{
		Components.Add(new Feet());
		Components.Add(new Padding());
		Components.Add(new Screws());
	}
}

public class Feet : Product
{
}

public class Padding : Product
{
}

public class Screws : Product
{
}