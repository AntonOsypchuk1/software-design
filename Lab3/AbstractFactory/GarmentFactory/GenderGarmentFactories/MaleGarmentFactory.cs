using AbstractFactory.GarmentFactory.Clothing;
using AbstractFactory.GarmentFactory.Clothing.ClothingInterfaces;

namespace AbstractFactory.GarmentFactory.GenderGarmentFactories;

public class MaleGarmentFactory : IGarmentFactory
{
    public IShoes CreateShoes()
    {
        return new MaleClothing.MaleShoes();
    }

    public ISocks CreateSocks()
    {
        return new MaleClothing.MaleSocks();
    }

    public IHat CreateHat()
    {
        return new MaleClothing.MaleHat();
    }

    public ITShirt CreateTShirt()
    {
        return new MaleClothing.MaleTShirt();
    }
}