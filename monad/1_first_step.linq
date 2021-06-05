<Query Kind="Program" />

void Main()
{
	string foo = null;
	//var foo = "Hello World";

	foo = ifNotNull(foo, str => str.Trim());
	foo = ifNotNull(foo, str => str.Substring(0, 5));
	int n = ifNotNull(foo, foo => foo.Length);

	n = n * n;

	n.Dump();
}

public R ifNotNull<T, R>(T v, Func<T, R> fn) => v == null ? default : fn(v);


// composition/chaining: ifNotNull(a, f)
//						.then((x) => ifNotNull(x, g))
//  					.then((x) => ifNotNull(x, j))
// ^^^ this is ugly


// we want:
// f(a).then(g).then(j) => ...
// or a.then(f).then(g).then(j) => ...

// in haskell 'then' can be an operator - it's called 'bind' and looks like >>=
// a >>= f >>= g >>= j => ...