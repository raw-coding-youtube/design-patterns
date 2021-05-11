<Query Kind="Program" />

void Main()
{
	
}

public class LogicA {
	
	Mediator m;

	public void Do(){
		m.DoLogic("b");
	}
}

public class Mediator {
	
	public void DoLogic(string logic){
		if(logic == "b"){
			new LogicB().Do();
		}
	}
}

public class LogicB
{
	public void Do()
	{

	}
}