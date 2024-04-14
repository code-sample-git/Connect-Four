using System;

public class GameController
{
    private GameBoard gameBoard;
    private Player player1;
    private Player player2;
    private Player currentPlayer;

    public GameController()
    {
        gameBoard = new GameBoard();
    }

    public void InitializePlayers()
    {
        Console.WriteLine("Please Choose Your Game mode (Human vs Human, Human vs AI);");
        Console.WriteLine("1. Human Vs Human");
        Console.WriteLine("2. AI Vs Human");

        string playerChoice = Console.ReadLine();


        if (playerChoice == "1")
        {
            Console.WriteLine("You have chosen Human Vs Human");

            player1 = new HumanPlayer("Player 1", 'X');
            player2 = new HumanPlayer("Player 2", 'O');
        }
        else if(playerChoice == "2")
        {
            Console.WriteLine("You have chosen Human Vs AI");

            player1 = new ComputerPlayer("AI Computer", 'X');
            player2 = new HumanPlayer("Human Player", 'O');

        }
        currentPlayer = player1;
    }

    public void StartGame()
    {
        bool GameOver = false;
        while(!GameOver)
        {
            gameBoard.DisplayBoard();
            Console.WriteLine($"It's {currentPlayer.Name}'s turn: ");

            int piece = currentPlayer.MakeMove();
            if (gameBoard.AddDisc(piece, currentPlayer.DiscSymbol))
            {
                if (gameBoard.CheckForWin(currentPlayer.DiscSymbol))
                {
                    gameBoard.DisplayBoard();
                    Console.WriteLine($"{currentPlayer.Name}'s has won!");
                    GameOver = true;
                }
                else if (gameBoard.IsFull())
                {
                    gameBoard.DisplayBoard();
                    Console.WriteLine("The game has ended, It's a Draw!");
                    GameOver = true;
                }
                else
                {
                    SwitchPlayer();
                }
            }
        }
    }

    private void SwitchPlayer()
    {
        currentPlayer = currentPlayer == player1 ? player2 : player1;
    }

}
