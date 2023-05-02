namespace ChainOfResponsibilities.LevelHandlers;

class Level4Handler : Handler
{
    public override bool Handle(string input)
    {
        if (input == "4")
        {
            Console.WriteLine("Please provide us with your billing information and we will assist you with your issue as soon as possible. Thank you for contacting us.");
            return true;
        }

        return false;
    }
}