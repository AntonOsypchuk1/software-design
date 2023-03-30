namespace ConsoleApp.Rpg;

public class Paladin : Hero
{
    public Paladin()
    {
        Health = 110;
        Strength = 7;
        Agility = 7;
        Intelligence = 10;
        Inventory = new List<string>();
    }
}