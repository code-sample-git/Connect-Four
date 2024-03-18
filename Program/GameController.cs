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
        //To be implement. Let the user choose the game mode (Human vs Human, Human vs AI, AI vs AI)
    }

    public void StartGame()
    {
       //To be implement. Start the game and handle the game loop
    }

    private void SwitchPlayer()
    {
        //To be implement. Switch the current player
    }
}
