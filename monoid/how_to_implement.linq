<Query Kind="Program" />

void Main()
{
	//  a: _ -> int
	//  5: _ -> int
	// 10: _ -> int
	Add15 add15 = (int a) => a + 5 + 10;
	add15(5).Dump();
	
	add15 = (int a) => Add5(a) + 10;
	add15(5).Dump();

	add15 = (int a) => Add10(Add5(a));
	add15(5).Dump();
}

public delegate int Add15(int a);

// add5: int -> int
public int Add5(int a){
	return a + 5;
}

// add10: int -> int
public int Add10(int a)
{
	return a + 10;
}