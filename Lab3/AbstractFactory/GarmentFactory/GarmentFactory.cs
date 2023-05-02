using AbstractFactory.GarmentFactory.GenderGarmentFactories;

namespace AbstractFactory.GarmentFactory;

public class GarmentFactory : IGarmentFactoryCreator
{
    public IGarmentFactory CreateGarmentFactory(Gender gender)
    {
        switch (gender)
        {
            case Gender.Male:
                return new MaleGarmentFactory();
            case Gender.Female:
                return new FemaleGarmentFactory();
            case Gender.Children:
                return new ChildrenGarmentFactory();
            default:
                throw new ArgumentException("Invalid gender specified.");
        }
    }
}