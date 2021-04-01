<Query Kind="Program" />

void Main()
{
	new CompositeComponent().Dump();
}

public interface IComponent
{
	IList<IComponent> Children { get; }
}

public class RegularComponent : IComponent
{
	public string Name = nameof(RegularComponent);
	public IList<IComponent> Children => null;
}

public class OrdinaryComponent : IComponent
{
	public string Name = nameof(OrdinaryComponent);
	public IList<IComponent> Children => null;
}

public class CompositeComponent : IComponent
{
	public string Name = nameof(CompositeComponent);
	public IList<IComponent> Children => new List<IComponent>
	{
		new RegularComponent(),
		new OrdinaryComponent(),
		new CompositeComponent(),
		new CompositeComponent(),
	};
}