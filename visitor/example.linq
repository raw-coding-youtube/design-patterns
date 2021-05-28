<Query Kind="Program" />

void Main()
{
	
}

public abstract class Place
{
	public abstract void Visit(Visitor visitor);	
}

public abstract class Visitor
{
	public abstract void VisitPark(Park park);
	public abstract void VisitHome(Home park);
}

public class Park : Place
{
	public override void Visit(Visitor visitor)
	{
		visitor.VisitPark(this);  
	}
}

public class Home : Place
{
	public override void Visit(Visitor visitor)
	{
		visitor.VisitHome(this);
	}
}

public class Dude : Visitor
{
	public override void VisitHome(Home park) => "play video games".Dump();

	public override void VisitPark(Park park) => "smoke weed".Dump();
}

public class Robber : Visitor
{
	public override void VisitHome(Home park) => "steal some socks".Dump();

	public override void VisitPark(Park park) => "steal a dog".Dump();
}