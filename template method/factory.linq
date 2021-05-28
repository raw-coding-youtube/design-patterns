<Query Kind="Program" />

void Main()
{
	new Variation1().Start();
	"--".Dump();
	new Variation2().Start();
	"--".Dump();
	new Variation3().Start();
}

public abstract class Process
{
	public void Start()
	{
		var word = FactoryMethod();
		// do something with word
	}

	protected abstract string FactoryMethod();
}

public class Variation1 : Process
{
	protected override string FactoryMethod() => "FactoryMethod Variation1".Dump();
}

public class Variation2 : Process
{
	protected override string FactoryMethod() => "FactoryMethod Variation2".Dump();
}

public class Variation3 : Process
{
	protected override string FactoryMethod() => "FactoryMethod Variation3".Dump();
}