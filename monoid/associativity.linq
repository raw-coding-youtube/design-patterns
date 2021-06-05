<Query Kind="Program" />

void Main()
{
	// rules for RULE1
	// associativity - doesn't matter how you group
	var add_sub_1 = add5 + (sub3 + add10);
	var add_sub_2 = (add5 + sub3) + add10;
	add_sub_1.run(5).Dump();
	add_sub_2.run(5).Dump();

	var mul_div_1 = mul3 + (div7 + mul5) + (sub3 + mul3);
	var mul_div_2 = mul3 + div7 + (mul5 + sub3) + mul3;
	mul_div_1.run(77).Dump();
	mul_div_2.run(77).Dump();

	// special member (abstract 0)
	((div7 + identity).run(5) == div7.run(5)).Dump();
	((identity + div7).run(5) == div7.run(5)).Dump();
}

public static int Add10(int a) => a + 10;

// collection of things
static Function<int> identity = new(a => a);
static Function<int> add5 = new(a => a + 5);
static Function<int> add10 = new(Add10);
static Function<int> sub3 = new(a => a - 3);
static Function<int> mul3 = new(a => a * 3);


static Function<int> mul5 = new(a => a * 5);
static Function<int> div7 = new(a => a / 7);

public struct Function<T>
{
	public Func<T, T> run;

	public Function(Func<T, T> fn) => run = fn;

	// RULE1 : rule for combining the things
	public static Function<T> operator +(
		Function<T> left,
		Function<T> right
		)
		=> new(x => left.run(right.run(x)));
}