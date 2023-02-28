using System.Numerics;
using System.Security;
using System.Text.Json;
using System.Text.Json.Serialization;

class TicTacToe
{
    static GameBoard gameBoard = new GameBoard();
    static Player playerX = new Player('X');
    static Player playerO = new Player('O');
    static Player currentPlayer = playerX;
    static List<int> previousField;


    public TicTacToe() => Play();

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
        Welcome();

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
                string key = Console.ReadLine();
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
                else
                {
                    int fieldNumber = int.Parse(key);
                    previousField.Add(fieldNumber);
                    Console.WriteLine(fieldNumber);
                }

                gameBoard.putMark(currentPlayer, playerX.takeTurn(key));
                gameBoard.clearBoard();
                moveCounter++;
                if (currentPlayer.checkWin(gameBoard))
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
                Console.WriteLine("Invalid Input. Please enter number between 1-9!");
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
                gameBoard = new GameBoard();
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
        catch(Exception)
        {
            Console.WriteLine("Invalid Input. Please enter only letter 'y' or 'n'.");
            Console.ReadLine();
            Console.Clear();
        }
        
    }

    private static void SaveGame()
    {
        string fileName = "C:\\Users\\user\\Desktop\\Лабы\\2 course\\2 term\\Конструювання ПЗ\\TicTacToe\\ConsoleApp\\saved-game.txt";
        const int ASCII_CODE_0 = 48;
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
                        if (gameBoard.Board[i, j].isEmpty())
                            writer.Write((char)(ASCII_CODE_0 + fieldNumber));
                        else
                            writer.Write((char)(gameBoard.Board[i, j].getFieldState()));
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
        string fileName = "C:\\Users\\user\\Desktop\\Лабы\\2 course\\2 term\\Конструювання ПЗ\\TicTacToe\\ConsoleApp\\saved-game.txt";
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
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (marks[j + i * 3] == 'X' || marks[j + i * 3] == 'O')
                            gameBoard.putMark(new Player(marks[j + i * 3]), j + i * 3 + 1);
                    }
                }

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