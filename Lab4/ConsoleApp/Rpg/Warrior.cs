namespace ConsoleApp.Rpg;

public class Warrior : Hero
{
    public Warrior()
    {
        Health = 100;
        Strength = 10;
        Agility = 5;
        Intelligence = 5;
        Inventory = new List<string>();
    }
}