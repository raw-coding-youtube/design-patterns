<Query Kind="Program" />

void Main()
{
	new Process().Start();
	"--".Dump();
	new Variation1().Start();
	"--".Dump();
	new Variation2().Start();
	"--".Dump();
	new Variation3().Start();
}

public class Process
{
	// template method
	public void Start()
	{
		Step1();
		Step2();
		Step3();
	}

	protected virtual void Step1() => "Step 1".Dump();
	protected virtual void Step2() => "Step 2".Dump();
	protected virtual void Step3() => "Step 3".Dump();
}

public class Variation1 : Process
{
	protected override void Step1() => "Step 1 Adapted".Dump();
}

public class Variation2 : Process
{
	protected override void Step3() => "Step 3 Adapted".Dump();
}

public class Variation3 : Process
{
	protected override void Step1() => "Step 1 Mega Adapted".Dump();

	protected override void Step2() => "Step 2 Adapted".Dump();
}