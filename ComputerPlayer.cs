using System;

public class ComputerPlayer : Player
{
    private Random random;

    public ComputerPlayer(string name, char discSymbol) : base(name, discSymbol)
    {
        random = new Random();
    }

    public override int MakeMove()
    {
        return random.Next(GameBoard.Columns);
    }
}
