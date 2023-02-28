public class Cell
{
    FIELD fieldState = FIELD.FLD_EMPTY;

    public Cell()
    {
        fieldState = FIELD.FLD_EMPTY;
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
            if (player.getSign() == 'X')
                fieldState = FIELD.FLD_X;
            else
                fieldState = FIELD.FLD_O;
        }
    }
}