namespace ConsoleApp.Rpg;

public abstract class Hero
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
    public List<string> Inventory { get; set; }

    public virtual void DisplayStats()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Agility: {Agility}");
        Console.WriteLine($"Intelligence: {Intelligence}");
        Console.WriteLine($"Inventory: {string.Join(", ", Inventory)}");
    }
}