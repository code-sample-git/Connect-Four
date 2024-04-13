using System;

public class HumanPlayer : Player
{
    public HumanPlayer(string name, char discSymbol) : base(name, discSymbol)
    {
    }

    public override int MakeMove()
    {
        Console.WriteLine($"{Name}, enter the column number (1-7) to place your piece: ");
        String input = Console.ReadLine();
        //if input is not a number, prompt the user to enter a number
        while (!int.TryParse(input, out int column) || column < 1 || column > 7)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            input = Console.ReadLine();
        }
        return int.Parse(input);

    }
}
