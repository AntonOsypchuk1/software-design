using AbstractFactory.GarmentFactory.Clothing;
using AbstractFactory.GarmentFactory.Clothing.ClothingInterfaces;

namespace AbstractFactory.GarmentFactory.GenderGarmentFactories;

public class ChildrenGarmentFactory : IGarmentFactory
{
    public IShoes CreateShoes()
    {
        return new ChildrenClothing.ChildrenShoes();
    }

    public ISocks CreateSocks()
    {
        return new ChildrenClothing.ChildrenSocks();
    }

    public IHat CreateHat()
    {
        return new ChildrenClothing.ChildrenHat();
    }

    public ITShirt CreateTShirt()
    {
        return new ChildrenClothing.ChildrenTShirt();
    }
}