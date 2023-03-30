namespace ConsoleApp.Rpg.decorators;

public class WeaponDecorator : InventoryDecorator
{
    public WeaponDecorator(Hero hero) : base(hero)
    {
        _hero.Inventory.Add("Weapons");
    }
}