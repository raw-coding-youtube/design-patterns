<Query Kind="Program" />

// smart function (glue+container)
// - smart is abstract - handle: io/null/state/try/flatten
// - glue is also a container/wrapper/package
// how do we unpack the value from the container to pass to the next function

// async/await/Task is a monad		   => await to unpack the value											
// .SelectMany is a monad (flatten)    => List<T>.SelectMany(Func<T, List<T>> f).SelectMany(Func<T, List<T>> f)
// wrapping try catch func			   => unpack the value after exception happens
// logging/state accumilation func     => log application is seperate from the function

void Main()
{
	string foo = null;
	//var foo = "Hello World";

	if (foo != null)
	{
		foo = foo.Trim();
	}
	if (foo != null)
	{
		foo = foo.Substring(0, 5);
	}
	int n = foo == null ? 0 : foo.Length;

	n = n * n;

	n.Dump();


	int nn = foo?.Trim()?.Substring(0, 5)?.Length ?? 0;
	nn = nn * nn;

	nn.Dump();
}