<Query Kind="Program" />

void Main()
{

}

// top level abstraction
public abstract class Vehicle {}

// implementation
public class Lada : Vehicle { }
public class Volvo : Vehicle { }

// lower level abstraction
public class LCar : Lada { }
public class LTruck : Lada { }
public class VCar : Volvo { }
public class VTruck : Volvo { }

// ---------------
// try to re-arrange
// ---------------

// lower level abstraction
public class Car : Vehicle { }
public class Truck : Vehicle { }

// implementations
public class L2Car : Car { }
public class L2Truck : Truck { }
public class V2Car : Car { }
public class V2Truck : Truck { }