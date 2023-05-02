using AbstractFactory.GarmentFactory.Clothing.ClothingInterfaces;

namespace AbstractFactory.GarmentFactory.Clothing;

public class ChildrenClothing
{
    public class ChildrenHat : IHat
    {
        public void Display()
        {
            Console.WriteLine("Children hat");
        }
    }
    
    public class ChildrenShoes : IShoes
    {
        public void Display()
        {
            Console.WriteLine("Children shoes");
        }
    }
    
    public class ChildrenSocks : ISocks
    {
        public void Display()
        {
            Console.WriteLine("Children socks");
        }
    }
    
    public class ChildrenTShirt : ITShirt
    {
        public void Display()
        {
            Console.WriteLine("Children T-shirt");
        }
    }
}