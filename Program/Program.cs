class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Connect Four!");

        GameController gameController = new GameController();

        // Initialize players based on chosen mode
        gameController.InitializePlayers();

        // Start the game
        gameController.StartGame();

        // After the game ends, prompt for another round or exit
        bool playAgain = false;
        do
        {
            Console.WriteLine("Play again? (y/n): ");
            char response = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after input

            if (response == 'y' || response == 'Y')
            {
                playAgain = true;
                gameController = new GameController(); // Re-initialize the game controller for a new game
                gameController.StartGame();
            }
            else
            {
                playAgain = false;
                Console.WriteLine("Thank you for playing Connect Four!");
            }
        }
        while (playAgain);
    }
}
