using AbstractFactory.GarmentFactory.GenderGarmentFactories;

namespace AbstractFactory.GarmentFactory;

public interface IGarmentFactoryCreator
{
    IGarmentFactory CreateGarmentFactory(Gender gender);
}