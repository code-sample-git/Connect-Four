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
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (j % 8 == 0)
                {
                    board[i, j] = '|';
                }
                else
                {
                    board[i, j] = '*';
                }
            }
        }
    }

    public bool AddDisc(int column, char disc, char board, String playerName)
    {
        
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
