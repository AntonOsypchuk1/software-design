namespace ConsoleApp.Rpg.decorators;

public class InventoryDecorator : Hero
{
    protected Hero _hero;

    public InventoryDecorator(Hero hero)
    {
        _hero = hero;
    }

    public override void DisplayStats()
    {
        _hero.DisplayStats();
    }
}