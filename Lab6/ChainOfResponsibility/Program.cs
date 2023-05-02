

using ChainOfResponsibilities.LevelHandlers;

var level1 = new Level1Handler();
var level2 = new Level2Handler();
var level3 = new Level3Handler();
var level4 = new Level4Handler();

level1.SetNext(level2).SetNext(level3).SetNext(level4);

Console.WriteLine("Welcome to our customer support system. Please choose from the following options:");

while (true)
{
    Handler handler = level1;

    Console.WriteLine("1. My account isn't working.");
    Console.WriteLine("2. I can't access your website.");
    Console.WriteLine("3. I have a question about your product.");
    Console.WriteLine("4. I have a billing issue.");
    Console.Write("Enter the number that best describes your problem: ");

    var input = Console.ReadLine();

    for (int i = 0; i < 4; i++)
    {
        if (handler.Handle(input))
        {
            Console.WriteLine("Thank you for contacting customer support. We hope we were able to assist you.");
            Console.WriteLine();
            break;
        }

        handler = handler.GetNext();

        if (handler == null)
        {
            Console.WriteLine("We're sorry, but we were unable to assist you. Please try again.");
            Console.WriteLine();
        }
    }
}
