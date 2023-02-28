public class Player
{
    char sign;
    int wins;

    public Player(char playerSign)
    {
        sign = playerSign;
    }

    public char getSign()
    {
        return sign;
    }

    public int getWins()
    {
        return wins;
    }

    public void setWins(int wins)
    {
        this.wins = wins;
    }

    public int takeTurn(string fieldNumber)
    {
        return int.Parse(fieldNumber);
    }

    private bool checkRowsForWin(GameBoard gameBoard)
    {
        for (int i = 0; i < GameBoard.BOARD_SIZE; i++)
        {
            if (checkRowCol(gameBoard.Board[i, 0].getFieldState(), gameBoard.Board[i, 1].getFieldState(), gameBoard.Board[i, 2].getFieldState()))
                return true;
        }
        return false;
    }

    private bool checkColumnsForWin(GameBoard gameBoard)
    {
        for (int i = 0; i < GameBoard.BOARD_SIZE; i++)
        {
            if (checkRowCol(gameBoard.Board[0, i].getFieldState(), gameBoard.Board[1, i].getFieldState(), gameBoard.Board[2, i].getFieldState()))
                return true;
        }
        return false;
    }

    private bool checkDiagonalsForWin(GameBoard gameBoard)
    {
        return ((checkRowCol(gameBoard.Board[0, 0].getFieldState(), gameBoard.Board[1, 1].getFieldState(), gameBoard.Board[2, 2].getFieldState()) == true) || (checkRowCol(gameBoard.Board[0, 2].getFieldState(), gameBoard.Board[1, 1].getFieldState(), gameBoard.Board[2, 0].getFieldState()) == true));
    }

    private bool checkRowCol(FIELD c1, FIELD c2, FIELD c3)
    {

        return (c1 != FIELD.FLD_EMPTY) && (c1 == c2) && (c2 == c3);
    }

    public bool checkWin(GameBoard gameBoard)
    {
        return (checkRowsForWin(gameBoard) || checkColumnsForWin(gameBoard) || checkDiagonalsForWin(gameBoard));
    }

    public void incrementWins() => wins++;
}