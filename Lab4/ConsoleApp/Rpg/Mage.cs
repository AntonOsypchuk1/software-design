namespace ConsoleApp.Rpg;

public class Mage : Hero
{
    public Mage()
    {
        Health = 70;
        Strength = 5;
        Agility = 5;
        Intelligence = 15;
        Inventory = new List<string>();
    }
}