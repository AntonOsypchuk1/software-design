namespace Builder.CharacterBuilder;

public class HeroBuilder : ICharacterBuilder
{
    private Character _character = new Character();

    public void SetHeight()
    {
        Console.WriteLine("What is your hero`s height?");
        var height = Console.ReadLine();
        _character.Height = height;
    }

    public void SetBuild()
    {
        Console.WriteLine("What is your hero`s build?");
        var build = Console.ReadLine();
        _character.Build = build;
    }

    public void SetHairColor()
    {
        Console.WriteLine("What is your hero`s hair color?");
        var hairColor = Console.ReadLine();
        _character.Build = hairColor;
    }
    
    public void SetEyeColor()
    {
        Console.WriteLine("What is your hero`s eye color?");
        var eyeColor = Console.ReadLine();
        _character.Build = eyeColor;
    }
    
    public void SetClothes()
    {
        Console.WriteLine("What is your hero`s clothes?");
        var clothes = Console.ReadLine();
        _character.Build = clothes;
    }
    
    public void SetInventory()
    {
        Console.WriteLine("What is your hero`s inventory?");
        var inventory = Console.ReadLine();
        _character.Build = inventory;
    }

    public Character GetCharacter()
    {
        Console.WriteLine("Hero created!");
        return _character;
    }
}