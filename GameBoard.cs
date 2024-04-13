using System;

public class GameBoard
{
    private const int Rows = 9;
    public const int Columns = 10;
    private char[,] board;

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
        if (column <= 0 || column > 7)
        {
            Console.WriteLine("Column is Out of Bounds.");
            return false;
         }

        for(int i = 5; i >= 0; i--) 
        {
            if (board[i, column] == '*')
            {
                board[i, column] = disc;
                return true;
            }
        }

        Console.WriteLine("Column is full.");
        return false;

    }

 public bool CheckForWin(char disc)
 {
        bool win = false;
        // Check horizontal, vertical, and diagonal lines for a win.
        for (int i = 8; i >= 1; --i)
        {

            for (int j = 9; j >= 1; --j)
            {

                if (board[i, j] == disc &&
                    board[i + 1, j + 1] == disc &&
                    board[i + 2, j + 2] == disc &&
                    board[i + 3, j + 3] == disc)
                {
                    return true;
                }


                if (board[i, j] == disc &&
                    board[i, j + 1] == disc &&
                    board[i, j + 2] == disc &&
                    board[i, j + 3] == disc)
                {
                    return true;
                }

                if (board[i, j] == disc &&
                    board[i + 1, j] == disc &&
                    board[i + 2, j] == disc &&
                    board[i + 3, j] == disc)
                {
                    return true;
                }

                if (board[i, j] == disc &&
                    board[i - 1, j + 1] == disc &&
                    board[i - 2, j + 2] == disc &&
                    board[i - 3, j + 3] == disc)
                {
                    return true;

                }

            }

        }

        return false;

}

    public void DisplayBoard()
    {
        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Columns; col++)
            {
                Console.Write(board[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    public bool IsFull()
    {
        for (int col = 0; col < Columns; col++)
        {
            if (board[0, col] == '*')
            {
                return false;
            }
        }
        return true;
    }
}
