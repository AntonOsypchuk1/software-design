using AbstractFactory.GarmentFactory.Clothing.ClothingInterfaces;

namespace AbstractFactory.GarmentFactory.Clothing;

public class MaleClothing
{
    public class MaleHat : IHat
    {
        public void Display()
        {
            Console.WriteLine("Male hat");
        }
    }
    
    public class MaleShoes : IShoes
    {
        public void Display()
        {
            Console.WriteLine("Male shoes");
        }
    }
    
    public class MaleSocks : ISocks
    {
        public void Display()
        {
            Console.WriteLine("Male socks");
        }
    }
    
    public class MaleTShirt : ITShirt
    {
        public void Display()
        {
            Console.WriteLine("Male T-shirt");
        }
    }
}