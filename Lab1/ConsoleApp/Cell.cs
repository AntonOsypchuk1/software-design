public class Cell
{
    FIELD fieldState = FIELD.FLD_EMPTY;
    public Char CellChar;
    public Cell(char cellChar)
    {
        fieldState = FIELD.FLD_EMPTY;
        CellChar = cellChar;
    }
    public FIELD getFieldState()
    {
        return fieldState;
    }
    public bool isEmpty()
    {
        if (fieldState != FIELD.FLD_EMPTY)
            return false;
        return true;
    }

    public void markField(Player player)
    {
        if (isEmpty())
        {
            CellChar = player.getSign();
            if (player.getSign() == 'X')
                fieldState = FIELD.FLD_X;
            else
                fieldState = FIELD.FLD_O;
        }
    }
}