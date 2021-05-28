<Query Kind="Program" />

void Main()
{

}


// other types? == more repos? generic repos?...
public interface IRepository
{
	int Get();
	int[] List();
	void Write(int id);
	void Update(int id);
}

public class Postgresql : IRepository
{
	
	public int Get()
	{
		throw new NotImplementedException();
	}

	public int[] List()
	{
		throw new NotImplementedException();
	}

	public void Update(int id)
	{
		throw new NotImplementedException();
	}

	public void Write(int id)
	{
		throw new NotImplementedException();
	}
}

public class MongoDb : IRepository
{
	public int Get()
	{
		throw new NotImplementedException();
	}

	public int[] List()
	{
		throw new NotImplementedException();
	}

	public void Update(int id)
	{
		throw new NotImplementedException();
	}

	public void Write(int id)
	{
		throw new NotImplementedException();
	}
}

public class Redis : IRepository
{
	public int Get()
	{
		throw new NotImplementedException();
	}

	public int[] List()
	{
		throw new NotImplementedException();
	}

	public void Update(int id)
	{
		throw new NotImplementedException();
	}

	public void Write(int id)
	{
		throw new NotImplementedException();
	}
}