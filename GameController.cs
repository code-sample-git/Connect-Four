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

        // Loop until a valid input is received
        while (playerChoice != "1" && playerChoice != "2")
        {
            Console.WriteLine("Invalid input. Please enter '1' for Human vs Human or '2' for Human vs AI.");
            playerChoice = Console.ReadLine();
        }

        if (playerChoice == "1")
        {
            Console.WriteLine("You have chosen Human Vs Human");
            Console.WriteLine("Please enter the name of Player 1");
            string player1Name = Console.ReadLine();
            while(player1Name == "")
            {
                Console.WriteLine("Name cannot be empty. Please enter the name of Player 1");
                player1Name = Console.ReadLine();
            }

            Console.WriteLine("Please enter the name of Player 2");
            string player2Name = Console.ReadLine();
            while(player2Name == "")
            {
                Console.WriteLine("Name cannot be empty. Please enter the name of Player 2");
                player2Name = Console.ReadLine();
            }

            player1 = new HumanPlayer(player1Name, 'X');
            player2 = new HumanPlayer(player2Name, 'O');
        }
        else if(playerChoice == "2")
        {
            Console.WriteLine("You have chosen Human Vs AI Computer");

            player1 = new ComputerPlayer("AI Computer", 'X');

            Console.WriteLine("Please enter the name of Humna Player");
            string humanPlayerName = Console.ReadLine();
            while(humanPlayerName == "")
            {
                Console.WriteLine("Name cannot be empty. Please enter the name of Human Player");
                humanPlayerName = Console.ReadLine();
            }

            player2 = new HumanPlayer(humanPlayerName, 'O');

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
