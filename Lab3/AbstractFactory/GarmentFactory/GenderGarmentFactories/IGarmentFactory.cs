using AbstractFactory.GarmentFactory.Clothing.ClothingInterfaces;

namespace AbstractFactory.GarmentFactory.GenderGarmentFactories;

public interface IGarmentFactory
{
    IShoes CreateShoes();
    ISocks CreateSocks();
    IHat CreateHat();
    ITShirt CreateTShirt();
}