<Query Kind="Program" />

void Main()
{

}

public interface IDumbData
{
	int Id { get; set; }
	string Name { get; set; }
	string Description { get; set; }
}

public class DumbData : IDumbData
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
}

public abstract class BaseDecrator : IDumbData
{
	protected IDumbData data;

	public BaseDecrator(IDumbData data) => this.data = data;

	public virtual int Id { get => data.Id; set => data.Id = value; }
	public virtual string Name { get => data.Name; set => data.Name = value; }
	public virtual string Description { get => data.Description; set => data.Description = value; }
}

public class InjectedFunctionality : BaseDecrator
{
	// supply original known object as parameter
	// enables composability
	public InjectedFunctionality(IDumbData data) : base(data) { }

	public override string Name
	{
		get => data.Name;
		set
		{
			data.Name = value
			EmitEvent(value);
		}
	}

	private void EmitEvent(string name)
	{
		// added functionality/responsiblity is not know to the outside, 
		// in favour of ability to pick decoration at runtime
	}
}