<Query Kind="Program">
  <Namespace>static UserQuery</Namespace>
</Query>

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
	var iterator = list.Iterator;
	
	while(!iterator.Complete){
		var n = iterator.Next();
		n.Dump("--");
	}
	iterator.Next();
}

public class LinkedList<T>
{
	private Node _node { get; set; }

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

	public LinkedIterator Iterator => new LinkedIterator(_node);

	public class LinkedIterator
	{
		Node _root;
		Node _current;
		public LinkedIterator(Node root) => _root = _current = root;

		public T Next()
		{
			var value = _current.Value;
			_current = _current.Next;
			return value;
		}

		public bool Complete => _current == null;

		public void Reset()
		{
			_current = _root;
		}

	}
}




