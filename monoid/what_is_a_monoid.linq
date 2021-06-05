<Query Kind="Program" />

void Main()
{
	int a = 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1;  		// + is monoid
	bool b = true || true || true || false || true; 		// || is monoid
	bool c = true && true && false;							// && is monoid
}

// add5: int -> int
public int Add5(int a) => a + 5;

// add10: int -> int
public int Add10(int a) => a + 10;

// add15: int -> int
// ???
// composed functions/(variables) are a monoid




// Task + Task + Task 
// CloudFunction + CloudFunction + CloudFunction
// VM + VM + VM
