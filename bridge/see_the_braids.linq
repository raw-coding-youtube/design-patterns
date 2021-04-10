<Query Kind="Program" />

void Main()
{

}

// top level abstraction
public abstract class Vehicle
{
	private Make make;

	public void Start()
	{
		make.PerformRitual();
		make.StartCar();
	}
	
	public abstract bool AllowedToDrive(string person);
}

public abstract class Make
{
	public abstract void PerformRitual();
	public abstract void StartCar();
}

// implementation
public class Lada : Make
{
	public override void PerformRitual() => "Hit the car".Dump();

	public override void StartCar() {
		"fix the wiring".Dump();
		"lube the engine".Dump();
		"put the key in".Dump();
		"turn the key".Dump();
	}
}

public class Volvo : Make
{
	public override void PerformRitual() => "Greatful for buying a volvo".Dump();

	public override void StartCar() => "Press button".Dump();
}

// lower level abstraction
public class Car : Vehicle
{
	public override bool AllowedToDrive(string person) => person == "has license";
}

public class Truck : Vehicle
{
	public override bool AllowedToDrive(string person) => person == "has special truck license";
}

