<Query Kind="Program" />

void Main()
{
	var list = new LinkedList<int>();
	list.Add(1);
	list.Add(2);
	list.Add(3);
	list.Add(4);
	list.Add(5);
	list.Add(6);
	list.Add(7);
	list.Dump();
	
	list.Get(3).Dump();
}

public class LinkedList<T> 
{
	public Node _node { get; set; }

	public class Node
	{
		public Node Next { get; set; }
		public T Value { get; set; }

		public void Append(T value)
		{
			if (Next == null)
			{
				Next = new Node { Value = value };
				return;
			}
			Next.Append(value);
		}

		public T Get(int i) => i == 0 ? Value : Next.Get(--i);
	}

	public void Add(T value)
	{
		if (_node == null)
		{
			_node = new Node { Value = value };
			return;
		}
		_node.Append(value);
	}

	public T Get(int i) => _node.Get(i);
}

