namespace Builder.CharacterBuilder;

public class EnemyBuilder : ICharacterBuilder
{
    private Character _character = new Character();

    public void SetHeight()
    {
        _character.Height = "Tall";
    }

    public void SetBuild()
    {
        _character.Build = "Muscular";
    }

    public void SetHairColor()
    {
        _character.HairColor = "Black";
    }
    
    public void SetEyeColor()
    {
        _character.EyeColor = "Red";
    }
    
    public void SetClothes()
    {
        _character.Clothes = "Armor";
    }
    
    public void SetInventory()
    {
        _character.Inventory = "Weapons";
    }

    public Character GetCharacter()
    {
        Console.WriteLine("Enemy created!");
        return _character;
    }
}