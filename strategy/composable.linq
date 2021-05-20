<Query Kind="Program" />

void Main()
{
	var chain1 = new Log().Append(new Transaction()).Append(new Add(5));
	chain1.Do(10);

	"-------------------".Dump();

	var chain2 = new Log().Append(new Add(10)).Append(new Transaction());
	chain2.Do(10);
}

public abstract class Strategy{
	
	private Strategy _next;
	
	public Strategy Append(Strategy next) {
		if(_next == null){
			_next = next;
		} else {
			_next.Append(next);
		}
		
		return this;
	}

	public abstract void Do(int n);
	
	protected void Next(int n) => _next?.Do(n);
}

public class Log : Strategy
{
	public override void Do(int n)
	{
		n.Dump("Logging number:");
		Next(n);
	}
}

public class Transaction : Strategy
{
	public override void Do(int n)
	{
		n.Dump("Starting Transaction");
		Next(n);
		n.Dump("Finishing Transaction");
	}
}

public class Add : Strategy
{
	int _num;
	public Add(int num) => _num = num;
	
	public override void Do(int n)
	{
		n.Dump($"Adding {_num} to {n}");
		int result = n += _num;
		n.Dump($"Result: {result}");
		Next(result);
	}
}