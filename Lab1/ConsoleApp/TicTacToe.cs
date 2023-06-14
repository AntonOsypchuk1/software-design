using ConsoleApp;
using System.Numerics;
using System.Security;
using System.Text.Json;
using System.Text.Json.Serialization;

class TicTacToe
{
    static IBoard gameBoard = new AlphabetGameBoard();
    static Player playerX = new Player('X');
    static Player playerO = new Player('O');
    static Player currentPlayer = playerX;
    static List<char> previousField = new List<char>();


    public TicTacToe()
    {
        Welcome();
        Play();
    }

    private static void Welcome()
    {
        Console.WriteLine("Let`s play Tic Tac Toe!\n");
        Console.WriteLine("Load previous game? (y/n)");
        if (Console.ReadLine() == "y")
        {
            LoadGame();
        }
    }

    public static void Play()
    {
        Console.WriteLine("Let`s play Tic Tac Toe!\n");
        Console.WriteLine("Player 1: {0} [{1}]", playerX.getSign(), playerX.getWins());
        Console.WriteLine("Player 2: {0} [{1}]", playerO.getSign(), playerO.getWins());

        Console.WriteLine("\nTo save game click 's'");
        Console.WriteLine("To undo previous action click 'u'\n");

        int moveCounter = 0;
        bool play = true;
        while (play)
        {
            gameBoard.printBoard();

            Console.WriteLine("Player: {0} Enter the field in which you want to put the character: ", currentPlayer.getSign());
            try
            {
                string key = Console.ReadLine().ToLower();
                if (key == "s")
                {
                    Console.Clear();
                    SaveGame();
                    continue;
                }
                else if (key == "u")
                {
                    Console.Clear();
                    gameBoard.undoAction(previousField.Last());
                    currentPlayer = ChangeCurrentPlayer(currentPlayer, playerX, playerO);
                    continue;
                }

                char fieldChar = Char.Parse(key);
                previousField.Add(fieldChar);
                if (!gameBoard.putMark(currentPlayer, fieldChar))
                {
                    Console.WriteLine("Cell is already occupied");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                gameBoard.clearBoard();
                moveCounter++;
                if (currentPlayer.checkWin(gameBoard.getBoard()))
                {
                    Console.WriteLine("Player: {0} wins!", currentPlayer.getSign());
                    gameBoard.printBoard();
                    Restart();
                    play = false;
                }
                else if (CheckDraw(moveCounter))
                {
                    Console.WriteLine("DRAW");
                    gameBoard.printBoard();
                    Restart();
                    play = false;
                }
                currentPlayer = ChangeCurrentPlayer(currentPlayer, playerX, playerO);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    private static void Restart()
    {
        Console.WriteLine("Restart game? (y/n)");
        string flag = Console.ReadLine();
        try
        {
            if (flag == "y")
            {
                Console.Clear();
                gameBoard = new AlphabetGameBoard();
                currentPlayer.incrementWins();
                currentPlayer = ChangeCurrentPlayer(currentPlayer, playerX, playerO);
                Play();
            }
            else
            {
                Console.WriteLine("Save game? (y/n)");
                if (Console.ReadLine() == "y")
                {
                    SaveGame();
                }
                return;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Input. Please enter only letter 'y' or 'n'.");
            Console.ReadLine();
            Console.Clear();
        }

    }

    private static void SaveGame()
    {
        string fileName = "saved-game.txt";
        int fieldNumber = 1;

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            try
            {
                writer.WriteLine(currentPlayer.getSign());
                writer.WriteLine(playerX.getWins());
                writer.WriteLine(playerO.getWins());
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        writer.Write(gameBoard.getBoard().Board[i, j].CellChar);
                        fieldNumber++;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine("Game saved to file.");
    }

    private static void LoadGame()
    {
        string fileName = "saved-game.txt";
        if (!File.Exists(fileName))
        {
            Console.WriteLine("No saved game found.\n");
            return;
        }
        using (StreamReader reader = new StreamReader(fileName))
        {
            try
            {
                currentPlayer = new(char.Parse(reader.ReadLine()));
                playerX.setWins(int.Parse(reader.ReadLine()));
                playerO.setWins(int.Parse(reader.ReadLine()));
                string marks = reader.ReadLine();
                gameBoard.loadBoard(marks);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine("Game loaded from file.\n");
    }

    private static Player ChangeCurrentPlayer(Player currentPlayer, Player playerX, Player playerO)
    {
        return currentPlayer == playerX ? playerO : playerX;
    }

    private static bool CheckDraw(int turnCounter)
    {
        return turnCounter == 9;
    }
}