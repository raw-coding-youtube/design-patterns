<Query Kind="Program" />

void Main()
{

}

// top level abstraction
public abstract class Vehicle {
	private Make make;
}

public abstract class Make {}

// implementation
public class Lada : Make { }
public class Volvo : Make { }

// lower level abstraction
public class Car : Vehicle { }
public class Truck : Vehicle { }
