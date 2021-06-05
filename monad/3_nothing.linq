<Query Kind="Program" />

void Main()
{
	Func<string, nil<int>> doTheThing = str => str.bind(trim).bind(sub(0, 5)).bind(len).bind(sqr);
	
	string foo = "Hello World";

	apiCall().bind(doTheThing).Value.Dump();
}

public nil<string> apiCall() {
	// doo fancy IO
	return nil<string>.Nothing;
}

Func<string, nil<string>> trim = x => x.Trim().ret();
Func<int, int, Func<string, nil<string>>> sub = (int s, int l) => x => x.Substring(s, l).ret();
Func<string, nil<int>> len = x => x.Length.ret();
Func<int, nil<int>> sqr = x => (x * x).ret();

public class nil<T>
{
	public nil(T value) => Value = value;
	protected nil(){}

	public T Value { get; set; }
	public virtual bool HasValue => true;
	public static nil<T> Nothing = new nothing<T>();
}

public class nothing<T> : nil<T>
{
	public override bool HasValue => false;
}
`
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