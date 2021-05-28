<Query Kind="Program" />

void Main()
{
}

public abstract class Process
{

	public void Start()
	{
		AbstractHook();
		DefaultHook();
	}
	
	public abstract void AbstractHook();
	
	public virtual void DefaultHook() {
		// default func
	}

}

public class A : Process
{
	public override void AbstractHook()
	{
		// override
	}
	
	public override void DefaultHook() {
		// prepend
		base.DefaultHook();
		// extend
	}
}