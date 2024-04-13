public abstract class Player
{
    public string Name { get; private set; }
    public char DiscSymbol { get; private set; }

    protected Player(string name, char discSymbol)
    {
        Name = name;
        DiscSymbol = discSymbol;
    }

    // Method to make a move. The exact implementation will be in the derived classes.
    // This method should return the column where the player decides to place their disc.
    public abstract int MakeMove();
}
