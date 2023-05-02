namespace ChainOfResponsibilities.LevelHandlers;

class Level3Handler : Handler
{
    public override bool Handle(string input)
    {
        if (input == "3")
        {
            Console.WriteLine("Please refer to our online documentation or contact our product support team. If you need more help, please contact us again.");
            return true;
        }

        return false;
    }
}