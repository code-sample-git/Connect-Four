using System;

public class GameBoard
{
    private const int Rows = 6;
    public const int Columns = 7;

    public GameBoard()
    {
        board = new char[Rows, Columns];
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        //To be implement. Initialize the game board with empty cells
    }

    public bool AddDisc(int column, char disc)
    {
        //To be implement. Add a disc to the game board
    }

    public bool CheckForWin(char disc)
    {
        //To be implement. Check if the player has won the game
        // Check horizontal, vertical, and diagonal lines for a win.
        
    }

    public void DisplayBoard()
    {
        //To be implement. Display the game board
    }

    public bool IsFull()
    {
        //To be implement. Check if the game board is full
    }
}
