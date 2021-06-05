<Query Kind="Program" />

void Main()
{
	// left identity: monad construction doesn't change function behaviour
	("Hello".bind(trim).Value == trim("Hello").Value).Dump();

	// right identity: re-wrapping doesn't change the value
	var helloMon = "Hello".ret();
	(helloMon.bind(hello => new nil<string>(hello)).Value == helloMon.Value).Dump();

	// associativity
	("Hello".bind(trim).bind(sub(0, 5)).Value ==
	 "Hello".bind(v => trim(v).bind(sub(0, 5))).Value).Dump();
}

Func<string, nil<string>> trim = x => x.Trim().ret();
Func<int, int, Func<string, nil<string>>> sub = 
	(int s, int l) => x => x.Substring(s, l).ret();
Func<string, nil<int>> len = x => x.Length.ret();
Func<int, nil<int>> sqr = x => (x * x).ret();

public class nil<T>
{
	public nil(T value) => Value = value;
	protected nil() { }

	public T Value { get; set; }
	public virtual bool HasValue => true;
	public static nil<T> Nothing = new nothing<T>();
}

public class nothing<T> : nil<T>
{
	public override bool HasValue => false;
}

public static class ext
{
	public static nil<T> ret<T>(this T value) => new nil<T>(value);

	// a.then(f).then(g).then(j)
	public static nil<C> bind<B, C>(this B b, Func<B, nil<C>> fn)
		=> b.ret().bind(fn);

	// f(a).then(g).then(j)	
	public static nil<C> bind<B, C>(this nil<B> b, Func<B, nil<C>> fn)
		=> b.HasValue ? fn(b.Value) : nil<C>.Nothing;
}