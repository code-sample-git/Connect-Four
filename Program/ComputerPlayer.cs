using System;

public class ComputerPlayer : Player
{
    private Random random;

    public ComputerPlayer(string name, char discSymbol) : base(name, discSymbol)
    {
        //To be implement. Initialize the random number generator
    }

    public override int MakeMove()
    {
        // To be implemented. How does the computer player decide which column to place their disc?
    }
}
