<Query Kind="Program" />

void Main()
{

}

public interface Abstraction { }

public class Concretion : Abstraction { }

public class ConcretionProxy : Abstraction
{
	// hide concretion, if we inject it we already exposed it
	// compile time decision
	Concretion concretion = new Concretion();

	// simulate/hook/intercept/interupt communication with Concretion
}

public class CocretionDecorator : Abstraction
{
	Abstraction _abstraction;

	// concretion is known
	// runtime decsion
	public CocretionDecorator(Abstraction abstraction)
	{
		_abstraction = abstraction;
	}

	// override concretion functionality
}