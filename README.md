# Connect Four Game Project

## Overview
This project is a C# implementation of the classic Connect Four game, where two players take turns dropping colored discs into a seven-column, six-row vertically suspended grid. The goal is to be the first to connect four of one's own discs horizontally, vertically, or diagonally.

## Getting Started
- Clone the repository to your local machine.
- Open the project in your preferred IDE (Visual Studio recommended for C# projects).
- Ensure you have .NET SDK installed to build and run the project.

## Development Guidelines

### Team Collaboration
- Use feature branches for each major development task. Branch names should follow the pattern `feature/<feature-name>`.
- Submit pull requests for code review before merging into the main branch.
- Regularly pull changes from the main branch to keep your feature branch up to date.

### Coding Standards
- Follow [Microsoft's C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions).
- Use meaningful names for classes, methods, and variables.
- Comment your code where necessary to explain complex logic or decisions.
- Keep methods and classes focused on a single responsibility.

### Project Structure
The project is divided into several key classes, each responsible for a different aspect of the game:
- `GameBoard.cs`: Manages the game board state and checks for win conditions.
- `Player.cs` (abstract): Defines common functionality for players.
- `HumanPlayer.cs`: Handles human player interactions.
- `ComputerPlayer.cs`: Implements AI for the computer player (optional for advanced development).
- `GameController.cs`: Controls the game flow, including player turns and game state.
- `Program.cs`: The entry point of the application.

### Task Assignments
- **Game Logic**: Responsible for implementing the game board and win condition logic.
- **Player Interaction**: Implements the player classes, handling both human and computer players.
- **Game Flow Control**: Develops the game controller to manage game states and turns.
- **UI and User Experience**: Focuses on console input/output for game interaction.

### Contributing
1. Pick a task from the project board or discuss with the team a task you'd like to take on.
2. Create a new feature branch for the task.
3. Develop your feature or fix, adhering to the coding standards.
4. Push your branch and create a pull request.
5. Request a code review from a team member.

## Running the Game
- Build the project using your IDE or the .NET CLI command `dotnet build`.
- Run the game using your IDE or the .NET CLI command `dotnet run`.

## Reporting Issues
- Use the GitHub Issues tab to report bugs or suggest enhancements.
- Clearly describe the issue or suggestion, providing steps to reproduce bugs if applicable.

