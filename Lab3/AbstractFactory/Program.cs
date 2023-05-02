

using AbstractFactory.GarmentFactory;
using AbstractFactory.GarmentFactory.GenderGarmentFactories;


var garmentFactory = new GarmentFactory();

Console.WriteLine("Creating male clothing...");
IGarmentFactory maleGarmentFactory = garmentFactory.CreateGarmentFactory(Gender.Male);
maleGarmentFactory.CreateShoes().Display();
maleGarmentFactory.CreateSocks().Display();
maleGarmentFactory.CreateHat().Display();
maleGarmentFactory.CreateTShirt().Display();

Console.WriteLine("Creating female clothing...");
IGarmentFactory femaleGarmentFactory = garmentFactory.CreateGarmentFactory(Gender.Female);
femaleGarmentFactory.CreateShoes().Display();
femaleGarmentFactory.CreateSocks().Display();
femaleGarmentFactory.CreateHat().Display();
femaleGarmentFactory.CreateTShirt().Display();

Console.WriteLine("Creating children clothing...");
IGarmentFactory childrenGarmentFactory = garmentFactory.CreateGarmentFactory(Gender.Children);
childrenGarmentFactory.CreateShoes().Display();
childrenGarmentFactory.CreateSocks().Display();
childrenGarmentFactory.CreateHat().Display();
childrenGarmentFactory.CreateTShirt().Display();