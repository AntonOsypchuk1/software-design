using AbstractFactory.GarmentFactory.Clothing;
using AbstractFactory.GarmentFactory.Clothing.ClothingInterfaces;

namespace AbstractFactory.GarmentFactory.GenderGarmentFactories;

public class FemaleGarmentFactory : IGarmentFactory
{
    public IShoes CreateShoes()
    {
        return new FemaleClothing.FemaleShoes();
    }

    public ISocks CreateSocks()
    {
        return new FemaleClothing.FemaleSocks();
    }

    public IHat CreateHat()
    {
        return new FemaleClothing.FemaleHat();
    }

    public ITShirt CreateTShirt()
    {
        return new FemaleClothing.FemaleTShirt();
    }
}