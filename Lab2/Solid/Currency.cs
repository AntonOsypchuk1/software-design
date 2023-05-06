namespace Solid;

// Liskov Substitution Principle:
// Objects of the same superclass can be replaced with
// objects of its subclasses without breaking the code

public class Currency
{
    public string Name { get; private set; }
    public string Symbol { get; private set; }

    public Currency(string name, string symbol)
    {
        Name = name;
        Symbol = symbol;
    }
}

// Dollar & Euro classes are the subclasses of Currency
// that represent the chosen currency 

public class Dollar : Currency
{
    public Dollar() : base("US dollar", "$")
    {
    }
}

public class Euro : Currency
{
    public Euro() : base("euro", "€")
    {
    }
}