using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class AlphabetGameBoard : IBoard
    {
        public const char FIRST_CHAR = 'a';
        public const char LAST_CHAR = 'i';
        private GameBoard gameBoard;
        public AlphabetGameBoard()
        {
            gameBoard = new GameBoard();
        }
        public void clearBoard()
        {
            gameBoard.clearBoard();
        }

        public GameBoard getBoard() => gameBoard;

        public void loadBoard(string marks)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (marks[j + i * 3] == 'X' || marks[j + i * 3] == 'O')
                        gameBoard.putMark(new Player(marks[j + i * 3]), j + i * 3 + 1);
                }
            }
        }

        public void printBoard()
        {
            int fieldNumber = 1;
            Console.WriteLine("\n");
            for (int i = 0; i < GameBoard.BOARD_SIZE; i++)
            {
                for (int j = 0; j < GameBoard.BOARD_SIZE; j++)
                {
                    char letter = toLetter(gameBoard.Board[i, j].CellChar);
                    Console.Write(letter.ToString().ToUpper());
                    fieldNumber++;

                    if (j < GameBoard.BOARD_SIZE - 1)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.Write("\n--+---+--\n");
            }
            Console.WriteLine("\n");
        }

        public bool putMark(Player player, char cellChar)
        {
            return gameBoard.putMark(player, toNumber(cellChar));
        }

        public void undoAction(char cellChar)
        {
            gameBoard.undoAction(toNumber(cellChar));
        }
        private char toLetter(char numberChar)
        {
            if (numberChar >= '1' && numberChar <= '9')
            {
                int number = int.Parse(numberChar.ToString());
                number--;
                char letter = (char)(FIRST_CHAR + number);
                return letter;
            }
            return numberChar;
        }
        private int toNumber(char letter)
        {
            if (letter >= FIRST_CHAR && letter <= LAST_CHAR)
            {
                int diff = letter - FIRST_CHAR;
                return diff + 1;

            }
            else
            {
                return 1000;
            }
        }
    }
}
