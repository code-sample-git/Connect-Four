using System;

public class GameController
{
    private GameBoard gameBoard;
    public Player DiscSymbol;
    public Player playerName;
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
        Console.WriteLine("2. Human Vs AI");

        string playerChoice = Console.ReadLine();

        player1 = new HumanPlayer("Player 1", 'X');

        if (playerChoice == "1")
        {
            Console.WriteLine("You have chosen Human Vs Human");

            player2 = new HumanPlayer("Player 2", 'O');
        }
        else if(playerChoice == "Human vs AI")
        {
            Console.WriteLine("You have chosen Human Vs AI");

            player2 = new HumanPlayer("Computer", 'O');
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
       //To be implement. Start the game and handle the game loop
    }

    private void SwitchPlayer()
    {
        currentPlayer = currentPlayer == player1 ? player2 : player1;
    }
}
