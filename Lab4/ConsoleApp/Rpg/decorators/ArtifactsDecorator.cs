namespace ConsoleApp.Rpg.decorators;

public class ArtifactsDecorator : InventoryDecorator
{
    public ArtifactsDecorator(Hero hero) : base(hero)
    {
        _hero.Inventory.Add("Artifacts");
    }
}