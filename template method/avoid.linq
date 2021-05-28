<Query Kind="Program" />

void Main()
{
}

public class Process
{
	public void Start()
	{
		A();
		B();
		C();
	}

	public void A() => "".Dump();
	public void B() => "".Dump();
	public void C() => "".Dump();
}

public class Process_Configured
{
	// more state === harder to understand
	public void Start(int a)
	{
		A();
		B();
		if (a == 0)
		{
			C();
		}
		else
		{
			D();
		}
	}

	public void A() => "".Dump();
	public void B() => "".Dump();
	public void C() => "".Dump();
	public void D() => "".Dump();
}


public class Process_Strategy
{
	// use strategy to supply the algorithm, DO NOT vary it
	Action strategy;
	public Process_Strategy(Action strategy) => this.strategy = strategy;
	
	public void Start()
	{
		A();
		B();
		strategy();
	}

	public void A() => "".Dump();
	public void B() => "".Dump();
}