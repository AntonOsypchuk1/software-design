using System.Reflection.PortableExecutable;

namespace Builder.CharacterBuilder;

public interface ICharacterBuilder
{
    void SetHeight();
    void SetBuild();
    void SetHairColor();
    void SetEyeColor();
    void SetClothes();
    void SetInventory();
    Character GetCharacter();
}