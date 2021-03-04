<Query Kind="Program" />

void Main()
{
	var builder = new CarBuilder();
	BuildRedLada1980(builder);
	builder.Build().Dump();
}

public void BuildRedLada1980(ICarBuilder builder)
{
	builder
		.setMake("lada")
		.setColour("red")
		.setManifactureDate(DateTime.UtcNow);
}

public class Car
{
	public string Make { get; set; }
	public string Colour { get; set; }
	public string ManifactureDate { get; set; }
}

public interface ICarBuilder
{
	public ICarBuilder setMake(string make);

	public ICarBuilder setColour(string colour);

	public ICarBuilder setManifactureDate(DateTime date);
}

public class CarBuilder : ICarBuilder
{
	private Car _car = new Car();

	public ICarBuilder setMake(string make)
	{
		_car.Make = make;
		return this;
	}

	public ICarBuilder setColour(string colour)
	{
		_car.Colour = colour;
		return this;
	}

	public ICarBuilder setManifactureDate(DateTime date)
	{
		_car.ManifactureDate = date.ToString("dd/MM/yyyy");
		return this;
	}
	
	public Car Build() => _car;
}