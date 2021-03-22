<Query Kind="Program" />

void Main()
{
	Func<int, int, int> add = PrintResult(Add);
	Func<int, int, int> addPrintSquare = Square(add);
	Func<int, int, int> addSquarePrint = PrintResult(Square(Add));

	add(5, 5);
	addPrintSquare(5, 5).Dump("after");
	addSquarePrint(5, 5);
}

public int Add(int a, int b) => a + b;

public Func<int, int, int> PrintResult(Func<int, int, int> fn)
{
	return (int a, int b) =>
	{
		int result = fn(a, b);

		result.Dump("inside");

		return result;
	};
}

public Func<int, int, int> Square(Func<int, int, int> fn)
{
	return (int a, int b) =>
	{
		int result = fn(a, b);
		return result * result;
	};
}