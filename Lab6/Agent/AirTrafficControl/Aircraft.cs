namespace Agent.AirTrafficControl;

public class Aircraft
{
    public string Name;
    public Runway? CurrentRunway { get; set; }
    public bool IsTakingOff { get; set; }

    public Aircraft(string name)
    {
        this.Name = name;
    }

    public void Land(CommandCentre commandCentre)
    {
        bool landed = commandCentre.RequestToLand(this);
        if (landed)
        {
            Console.WriteLine($"Aircraft {this.Name} has landed.");
        }
    }

    public void TakeOff(CommandCentre commandCentre)
    {
        commandCentre.RequestToTakeOff(this);
    }
}