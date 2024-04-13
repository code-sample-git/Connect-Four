using System;

public class HumanPlayer : Player
{
    public HumanPlayer(string name, char discSymbol) : base(name, discSymbol)
    {
    }

    public override int MakeMove()
    {
        Console.WriteLine($"{Name}, enter the column number (1-7) to place your piece: ");
        int piece = Convert.ToInt32(Console.ReadLine());
        while(true)
        {
            if(piece > 0 && piece < 7)
            {
                return piece;
            }
            else
            {
                Console.WriteLine("Your number is outside the bounds of the board. Please choose a number between 1-7 again:");
                piece = Convert.ToInt32(Console.ReadLine());
            }
        }
        //To be implement. Prompt the user for a column and return the value
        //To be implemented
    }
}
