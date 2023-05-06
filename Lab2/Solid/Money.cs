namespace Solid;

// Single Responsibility Principle: Each class is responsible for a single 
// aspect of the system's functionality

public class Money
{
    public int WholePart { get; private set; }
    public int Pennies { get; private set; }
    public Currency Currency { get; private set; }

    public Money(int wholePart, int pennies, Currency currency)
    {
        WholePart = wholePart;
        Pennies = pennies;
        Currency = currency;
    }

    public void Display()
    {
        Console.WriteLine($"$ {WholePart}.{Pennies:D2}");
    }

    public void SetValues(int wholePart, int pennies)
    {
        WholePart = wholePart;
        Pennies = pennies;
    }
}