<Query Kind="Program" />

void Main()
{
	string foo = null;
	//string foo = "Hello World";

	foo.bind(x => x.Trim().nil())
		.bind(x => x.Substring(0, 5).nil())
		.bind(x => x.Length.nil())
		.bind(x => (x * x).nil())
		.Value
		.Dump();
}

public struct nil<T>
{
	public nil(T value) => Value = value;

	public T Value { get; set; }
	public bool HasValue => Value != null;
}

public static class ext
{
	public static nil<T> nil<T>(this T value) => new nil<T>(value);

	// a.then(f).then(g).then(j)
	public static nil<C> bind<B, C>(this B b, Func<B, nil<C>> fn)
		=> b.nil().bind(fn);
		
	// f(a).then(g).then(j)	
	public static nil<C> bind<B, C>(this nil<B> b, Func<B, nil<C>> fn)
		=> b.HasValue ? fn(b.Value) : new nil<C>();
}

// f1 : a -> container<b>
// f2 : b -> container<c>	 

// f3 : a -> container<c>

// f3 = a -> f1(a).bind(f2) === a -> a.bind(f1).bind(f2)
// f3 = a -> a >> smart transfer >> f1 >> smart transfer >> f2

// bind in haskell >>=
// >>= : smart transfer
// f3 = a >>= f1 >>= f2
// (left) >>= (right) = right(smart_transfer(left))


