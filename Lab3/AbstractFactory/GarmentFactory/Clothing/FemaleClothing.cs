using AbstractFactory.GarmentFactory.Clothing.ClothingInterfaces;

namespace AbstractFactory.GarmentFactory.Clothing;

public class FemaleClothing
{
    public class FemaleHat : IHat
    {
        public void Display()
        {
            Console.WriteLine("Female hat");
        }
    }
    
    public class FemaleShoes : IShoes
    {
        public void Display()
        {
            Console.WriteLine("Female shoes");
        }
    }
    
    public class FemaleSocks : ISocks
    {
        public void Display()
        {
            Console.WriteLine("Female socks");
        }
    }
    
    public class FemaleTShirt : ITShirt
    {
        public void Display()
        {
            Console.WriteLine("Female T-shirt");
        }
    }
}