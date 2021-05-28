<Query Kind="Program" />

void Main()
{
	IRepository repo = new Postgres();
	var operation = new GetInt();
	repo.Visit(operation);
	operation.Result.Dump();
}


public interface IRepository
{
	void Visit(IOperation operation);
}

public interface IOperation
{
	void VisitPostgres(Postgres pg);
	void VisitMongoDb(MongoDb md);
	void VisitRedis(Redis rd);
}

public class Postgres : IRepository
{
	public string client;
	public void Visit(IOperation operation)
	{
		operation.VisitPostgres(this);
	}
}

public class MongoDb : IRepository
{
	public string client;
	public void Visit(IOperation operation)
	{
		operation.VisitMongoDb(this);
	}
}

public class Redis : IRepository
{
	public string client;
	public void Visit(IOperation operation)
	{
		operation.VisitRedis(this);
	}
}

public abstract class Get<T> : IOperation
{
	public T Result { get; set; }
	
	public abstract void VisitMongoDb(MongoDb md);

	public abstract void VisitPostgres(Postgres pg);

	public abstract void VisitRedis(Redis rd);
}

public class GetInt : Get<int>
{
	public override void VisitPostgres(Postgres pg)
	{
		Result = 6;
	}
	
	public override void VisitMongoDb(MongoDb md)
	{
		Result = 5;
	}

	public override void VisitRedis(Redis rd)
	{
		Result = 7;
	}
}
