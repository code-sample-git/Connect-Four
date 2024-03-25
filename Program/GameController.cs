using System;

public class GameController
{
    private GameBoard gameBoard;
    public Player DiscSymbol;
    public Player playerName;
    private Player currentPlayer;

    public GameController()
    {
        gameBoard = new GameBoard();
    }

    public void InitializePlayers()
    {
        Console.WriteLine("Please Choose Your Game mode (Human vs Human, Human vs AI);");
        String PlayerChoice = Console.ReadLine();
        playerName player1 = new playerName();
        playerName player2 = new playerName();
        if(PlayerChoice == "Human vs Human")
        {
            Console.WriteLine("You have chosen Human Vs Human\n");

            Console.WriteLine("What is your name player 1?");
            playerName.player1 = Console.ReadLine();
            Console.WriteLine("What is your name player 2?");
            playerName.player2 = Console.ReadLine();
        }
        else if(PlayerChoice == "Human vs AI")
        {
            Console.WriteLine("You have chosen Human Vs AI\n");
            Console.WriteLine("What is your name player 1?");
            player1 = Console.ReadLine();
        }
        //To be implement. Let the user choose the game mode (Human vs Human, Human vs AI, AI vs AI)
    }

    public void StartGame()
    {
        do
        {
            gameBoard.DisplayBoard();
            Console.WriteLine("Which column would you like to place your piece? (1 - 7)");
            player1.
        } while (GameOver != true);
       //To be implement. Start the game and handle the game loop
    }

    private void SwitchPlayer()
    {
        //To be implement. Switch the current player
    }
}
