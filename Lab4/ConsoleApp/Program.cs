using System.Collections.Generic;
using ConsoleApp.BigMac;
using ConsoleApp.GraphicEditor;
using ConsoleApp.GraphicEditor.renderer;
using ConsoleApp.Logger;
using ConsoleApp.Rpg;
using ConsoleApp.Rpg.decorators;

Loggers(); // Test Logger classes
Rpg(); // Test Decorator classes
BigMac(); // Test Facade classes
GraphicEditor(); // Test Bridge classes

void Loggers()
{
    var logger = new Logger();
    logger.Log("This is an informational message");
    logger.Error("This is an error message");
    logger.Warn("This is an warning message");

    // Test FileLogger class
    var fileLogger = new FileLogger("log.txt");
    fileLogger.Log("This is an informational message");
    fileLogger.Error("This is an error message");
    fileLogger.Warn("This is an warning message");
}

void Rpg()
{
    var warrior = new Warrior();
    var warriorWithClothing = new ClothingDecorator(warrior);
    var warriorFull = new WeaponDecorator(warrior);

    var mage = new Mage();
    var mageWithClothing = new ClothingDecorator(mage);
    var mageFull = new ArtifactsDecorator(mage);

    var paladin = new Paladin();
    var clothingDecorator = new ClothingDecorator(paladin);
    var paladinWithWeapon = new WeaponDecorator(paladin);
    var paladinFull = new ArtifactsDecorator(paladin);

    warriorFull.DisplayStats();
    Console.WriteLine();
    mageFull.DisplayStats();
    Console.WriteLine();
    paladinFull.DisplayStats();
}

void BigMac()
{
    var bigMacMenu = new BigMacMenuFacade();

    Console.WriteLine("BigMac Menu:");
    Console.WriteLine(bigMacMenu.GetMenu());

    Console.WriteLine("\nOrdering a BigMac meal with fries and a Coke...");
    var meal = bigMacMenu.OrderBigMacMeal();
    Console.WriteLine(meal);
}

void GraphicEditor()
{
    Console.WriteLine("Drawing shapes as raster graphics:");
    Bridge.Run(new RasterRenderer());

    Console.WriteLine("\nDrawing shapes as vector graphics:");
    Bridge.Run(new VectorRenderer());
}