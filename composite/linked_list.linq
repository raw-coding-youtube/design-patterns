<Query Kind="Program" />

void Main()
{
	var list = new LinkedList<int>();	
	
	list.Add(1);
	list.Add(2);
	list.Add(3);
	list.Add(4);
	
	list.Get(0).Dump();
	list.Get(1).Dump();
	list.Get(2).Dump();
	list.Get(3).Dump();
	list.Get(4).Dump();
}

public class LinkedList<T> 
{
	public LinkedList() {}
	public LinkedList(T v) => value = v;

	T value;
	LinkedList<T> _next;

	public T Get(int i)
	{
		if (_next == null)
		{
			throw new IndexOutOfRangeException();
		}
		
		if (i == 0)
		{
			return value;
		}
		
		return _next.Get(--i);
	}

	public void Add(T v)
	{
		if (_next == null)
		{
			value = v;
			_next = new LinkedList<T>();
		}
		else
		{
			_next.Add(v);
		}
	}

}