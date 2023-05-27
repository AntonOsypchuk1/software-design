using System.Numerics;

public class GameBoard
{
    public const int BOARD_SIZE = 3;
    public Cell[,] Board;

    public GameBoard()
    {
        initializeBoard();
    }

    private void initializeBoard()
    {
        Board = new Cell[BOARD_SIZE, BOARD_SIZE];
        for (int i = 0; i < BOARD_SIZE * BOARD_SIZE; i++)
        {
            int row = i / BOARD_SIZE;
            int column = i % BOARD_SIZE;
            var c = Char.Parse((i + 1).ToString());
            Board[row, column] = new Cell(c);

        }
    }

    public void printBoard()
    {
        int fieldNumber = 1;
        Console.WriteLine("\n");
        for (int i = 0; i < BOARD_SIZE; i++)
        {
            for (int j = 0; j < BOARD_SIZE; j++)
            {
                Console.Write(Board[i, j].CellChar);
                fieldNumber++;

                if (j < BOARD_SIZE - 1)
                {
                    Console.Write(" | ");
                }
            }
            Console.Write("\n--+---+--\n");
        }
        Console.WriteLine("\n");
    }

    public void undoAction(int fieldNumber)
    {
        int verticalY = (fieldNumber - 1) / 3;
        int horizontalX = (fieldNumber - 1) % 3;
        if (!Board[verticalY, horizontalX].isEmpty())
        {
            var c = Char.Parse(fieldNumber.ToString());
            Board[verticalY, horizontalX] = new Cell(c);
        }
        else
        {
            Console.WriteLine("You can`t undo action twice!");
        }
    }

    public void putMark(Player player, int fieldNumber)
    {

        int verticalY = (fieldNumber - 1) / 3;
        int horizontalX = (fieldNumber - 1) % 3;
        if (Board[verticalY, horizontalX].isEmpty())
        {
            Board[verticalY, horizontalX].markField(player);
        }
        else
        {
            Console.WriteLine("This place is taken. Select the field again: ");
            string key = Console.ReadLine();
            putMark(player, player.takeTurn(key));
        }
    }

    public void clearBoard()
    {
        Console.Clear();
    }
}