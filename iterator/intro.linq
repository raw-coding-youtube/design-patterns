<Query Kind="Program" />

void Main()
{
	foreach (var n in NumberIterator(10))
	{
		n.Dump();
	}
}

public IEnumerable<int> NumberIterator(int l){
	for (int i = 0; i < l; i++)
	{
		yield return i;		
	}
}

