namespace ConsoleApp.Rpg.decorators;

public class ClothingDecorator : InventoryDecorator
{
    public ClothingDecorator(Hero hero) : base(hero)
    {
        _hero.Inventory.Add("Clothing");
    }
}