using System.Runtime.Loader;
using Task2.Composite;

MarvelHero mainCharacter = new MarvelHero("Thor", 100);

MarvelHero ironMan = new MarvelHero("Iron Man", 150);

CompositeArtefact gloveOfPower = new CompositeArtefact("Glove of Power", 20, 50);

Artefact spaceStone = new Artefact("Space Stone", 2, 10);
Artefact powerStone = new Artefact("Power Stone", 3, 20);
Artefact realityStone = new Artefact("Reality Stone", 1, 30);
Artefact soulStone = new Artefact("Soul Stone", 2, 40);
Artefact mindStone = new Artefact("Mind Stone", 1, 50);
Artefact timeStone = new Artefact("Time Stone", 2, 60);

gloveOfPower.AddArtefact(spaceStone);
gloveOfPower.AddArtefact(powerStone);
gloveOfPower.AddArtefact(realityStone);
gloveOfPower.AddArtefact(soulStone);
gloveOfPower.AddArtefact(mindStone);

ironMan.AddArtefact(gloveOfPower);

mainCharacter.AddFriend(ironMan);

Artefact hammer = new Artefact("Mjolnir", 10, 50);
Artefact armor = new Artefact("Armor", 15, 20);
mainCharacter.AddArtefact(hammer);
mainCharacter.AddArtefact(armor);

mainCharacter.AddArtefactEventArgs += (sender, e) =>
{
    Console.WriteLine($"Added {e.Artefact.Name} to {mainCharacter.Name}");
};

mainCharacter.AddArtefactEventArgs += (sender, e) =>
{
    Console.WriteLine($"Removed {e.Artefact.Name} from {mainCharacter.Name}");
};

mainCharacter.CountArtefacts();
mainCharacter.CalculateArtefactsWeight();
mainCharacter.Strike();