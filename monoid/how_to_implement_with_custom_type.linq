<Query Kind="Program" />

void Main()
{
	var add15 = add5 + add10;

	add15.run(5).Dump();
}

public static int Add10(int a) => a + 10;

static Function<int> add5 = new(a => a + 5);
static Function<int> add10 = new(Add10);

public struct Function<T>
{
	public Func<T, T> run;

	public Function(Func<T, T> fn) => run = fn;

	// then is a monoid
	public Function<T> Then(Function<T> next)
	{
		var runCopy = run;
		return new(x => runCopy(next.run(x)));
	}

	// + is a monoid
	public static Function<T> operator +(
		Function<T> left,
		Function<T> right
		)
		=> new(x => left.run(right.run(x)));
}

public static class FunctionExt{

	// then is a monoid
	public static Function<T> Then<T>(this Function<T> @this, Function<T> next) {
		return new(x => @this.run(next.run(x)));
	}
}