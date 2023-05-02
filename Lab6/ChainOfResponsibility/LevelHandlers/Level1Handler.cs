namespace ChainOfResponsibilities.LevelHandlers;

class Level1Handler : Handler
{
    public override bool Handle(string input)
    {
        if (input == "1")
        {
            Console.WriteLine("Please try logging out and logging back in again. If that doesn't work, please contact us again.");
            return true;
        }

        return false;
    }
}