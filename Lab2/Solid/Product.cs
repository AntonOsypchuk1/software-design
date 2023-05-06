namespace Solid;

// Open/Closed Principle:
// The classes are open for extension, but closed for modification

public class Product
{
    public string Name { get; private set; }
    public Money Price { get; private set; }
    public string UnitOfMeasurement { get; set; }
    public int Quantity { get; set; }

    public Product(string name, Money price, string unitOfMeasurement, int quantity)
    {
        Name = name;
        Price = price;
        UnitOfMeasurement = unitOfMeasurement;
        Quantity = quantity;
    }

    public void ReducePrice(int amount)
    {
        Price.SetValues(Price.WholePart, Price.Pennies - amount);
    }
}