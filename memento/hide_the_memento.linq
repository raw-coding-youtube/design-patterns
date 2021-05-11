<Query Kind="Program" />

void Main()
{

}

public class A
{
	private int c;

	int Do(A a) => a.c;

	A GetState() => new A();
}


public class B
{
	private int c;

	public class C
	{
		public int Do(B b) => b.c;

		public B GetState() => new B();
	}
}

public class D
{
	public interface C	{}
	
	private class E : C
	{
		public int c;
	}
	
	private E e;

	public int Do(C b) => ((E)b).c;

	public C GetState() => e;
}
