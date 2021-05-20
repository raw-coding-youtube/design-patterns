<Query Kind="Program" />

void Main()
{

}

public partial class Computer
{
	private State _state = new Off();

	private void SetState(State state)
	{
		_state = state;
	}

	public void PressPowerButton()
	{
		_state.PressPowerButton(this);
	}
}

public partial class Computer
{
	private interface State
	{
		void PressPowerButton(Computer computer);
	}

	private class Off : State
	{
		public void PressPowerButton(Computer computer)
		{
			// perform some work
			computer.SetState(new On());
		}
	}

	private class On : State
	{
		private bool charging;
		
		public void PressPowerButton(Computer computer)
		{
			// perform some work
			if (charging)
			{
				computer.SetState(new Standby());
			}
			else
			{
				computer.SetState(new Off());
			}
		}
	}

	private class Standby : State
	{
		public void PressPowerButton(Computer computer)
		{
			// perform some work
			computer.SetState(new On());
		}
	}
}
