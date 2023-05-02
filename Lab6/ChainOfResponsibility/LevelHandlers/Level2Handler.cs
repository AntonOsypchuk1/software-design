namespace ChainOfResponsibilities.LevelHandlers;

class Level2Handler : Handler
{
    public override bool Handle(string input)
    {
        if (input == "2")
        {
            Console.WriteLine("Please try clearing your browser's cache and cookies. If that doesn't work please contact us again.");
            return true;
        }

        return false;
    }
}