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

    public bool AddDisc(int column, char disc)
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
        // Check for horizontal, vertical, and diagonal wins

        // Horizontal and vertical win conditions
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns - 3; j++) // leave space for 4 consecutive discs
            {
                // Horizontal check
                if (board[i, j] == disc && board[i, j + 1] == disc && board[i, j + 2] == disc && board[i, j + 3] == disc)
                    return true;
            }
        }

        for (int i = 0; i < Rows - 3; i++) // leave space for 4 consecutive discs vertically
        {
            for (int j = 0; j < Columns; j++)
            {
                // Vertical check
                if (board[i, j] == disc && board[i + 1, j] == disc && board[i + 2, j] == disc && board[i + 3, j] == disc)
                    return true;
            }
        }

        // Diagonal win conditions
        for (int i = 0; i < Rows - 3; i++)
        {
            for (int j = 0; j < Columns - 3; j++)
            {
                // Diagonal down-right
                if (board[i, j] == disc && board[i + 1, j + 1] == disc && board[i + 2, j + 2] == disc && board[i + 3, j + 3] == disc)
                    return true;
            }
        }

        for (int i = 3; i < Rows; i++) // start from row 3 to have space for diagonal up-right
        {
            for (int j = 0; j < Columns - 3; j++)
            {
                // Diagonal up-right
                if (board[i, j] == disc && board[i - 1, j + 1] == disc && board[i - 2, j + 2] == disc && board[i - 3, j + 3] == disc)
                    return true;
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
                char cell = board[row, col];
                if (cell == 'X')
                {
                    Console.ForegroundColor = ConsoleColor.Red;  // Set text color to red
                }
                else if (cell == 'O')
                {
                    Console.ForegroundColor = ConsoleColor.Blue; // Set text color to blue
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White; // Default color for empty slots
                }

                Console.Write(cell + " ");
                Console.ResetColor(); // Reset to default colors
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
