<Query Kind="Program" />

void Main()
{

}

public class Computer
{
	private int state = 0;
	private bool charging = true;

	public void PressPowerButton()
	{
		// off
		if (state == 0)
		{
			// do work
			state = 1;
			return;
		}
		
		// on
		if (state == 1)
		{
			// do work
			if (charging)
			{
				state = 2;
				return;
			}
			state = 0;
			return;
		}
		
		// standby
		// do work
		state = 1;
	}
}


