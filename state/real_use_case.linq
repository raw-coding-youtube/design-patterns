<Query Kind="Program" />

void Main()
{

}

public partial class Pen
{
	private State _state = new Idle();

	private void SetState(State state) => _state = state;

	public void OnClick(Pen pen) => _state.OnClick(this);

	public void OnClickFinish(Pen pen) => _state.OnClickFinish(this);

	public void OnMove(Pen pen) => _state.OnMove(this);
}

public partial class Pen
{
	private interface State
	{
		void OnMove(Pen pen);
		void OnClick(Pen pen);
		void OnClickFinish(Pen pen);
	}

	private class Idle : State
	{
		public void OnClick(Pen pen)
		{
			pen.SetState(new Writing());
		}

		public void OnClickFinish(Pen pen)
		{
			// do nothing
		}

		public void OnMove(Pen pen)
		{
			// do nothing
		}
	}

	private class Writing : State
	{
		public void OnClick(Pen pen)
		{
			// DRAW HARDER
		}

		public void OnClickFinish(Pen pen)
		{
			pen.SetState(new Idle());
		}

		public void OnMove(Pen pen)
		{
			// draw on canvas
		}
	}

}
