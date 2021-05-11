<Query Kind="Program" />

void Main()
{
	var player = new Player();

	player.GoForward();
	player.GoForward();
	player.GoForward();
	player.GoBack();
	player.GoBack();
	player.GoForward();
	player.GoForward();
	player.GoBack();
}

public class Player
{
	List<Position> positionMemory = new();
	Position.Piece piece = new();

	public void GoForward()
	{
		// roll dice
		var position = piece.GetPosition();
		positionMemory.Add(position);
		
		int n = new Random().Next(1, 6);
		piece.Move(n);
	}
	
	public void GoBack(){
		var position = positionMemory.Last();
		positionMemory.Remove(position);
		piece.SetPosition(position);
	}
}

public struct Position
{
	private int Cell { get; set; }

	public class Piece
	{
		public Position _position = new Position() { Cell = 0.Dump("Starting At") };


		public void Move(int n) => (_position.Cell += n).Dump("Moving To");

		public Position GetPosition() => new Position { Cell = _position.Cell };

		public void SetPosition(Position p) => _position.Cell = p.Cell.Dump("Going Back To");
	}

}
