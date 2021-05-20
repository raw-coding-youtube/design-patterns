<Query Kind="Program" />

void Main()
{
	new Thing<A>().Do();
	new Thing<B>().Do();
}

public class Thing<T> where T : class, IStrategy, new()
{	
	public void Do() => new T().Do();
}

public interface IStrategy {
	void Do();
}

public class A : IStrategy
{
	public void Do() => "a".Dump();
}

public class B : IStrategy
{
	public void Do() => "b".Dump();
}