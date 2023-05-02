namespace Builder.CharacterBuilder;

public class CharacterDirector
{
    private ICharacterBuilder _characterBuilder;

    public CharacterDirector(ICharacterBuilder builder)
    {
        _characterBuilder = builder;
    }

    public void BuildCharacter()
    {
        _characterBuilder.SetHeight();
        _characterBuilder.SetBuild();
        _characterBuilder.SetHairColor();
        _characterBuilder.SetEyeColor();
        _characterBuilder.SetClothes();
        _characterBuilder.SetInventory();
    }

    public Character GetCharacter()
    {
        return _characterBuilder.GetCharacter();
    }
}