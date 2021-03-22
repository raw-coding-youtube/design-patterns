<Query Kind="Program" />

void Main()
{
	var d = new Doer();
	d.Something();
	"---".Dump();
	
	var atd = new AnotherThing(d);
	atd.Something();
	"---".Dump();
	
	var iad = new InAddition(d);
	iad.Something();
	"---".Dump();
	
	var iaatd = new InAddition(atd);
	iaatd.Something();
	"---".Dump();
	
	var atiad = new AnotherThing(iad);
	atiad.Something();
}

public interface IDoSomething
{
	void Something();
}

public class Doer : IDoSomething
{
	public void Something() => "Something".Dump();
}

public class AnotherThing : IDoSomething
{
	protected IDoSomething _doSomething;

	public AnotherThing(IDoSomething doSomething) => _doSomething = doSomething;

	public void Something()
	{
		_doSomething.Something();
		"Another Thing".Dump();
	}
}

public class InAddition : IDoSomething
{
	protected IDoSomething _doSomething;

	public InAddition(IDoSomething doSomething) => _doSomething = doSomething;

	public void Something()
	{
		_doSomething.Something();
		"In Addition".Dump();
	}
}