namespace Agent.AirTrafficControl;

public class Runway
{
    public readonly Guid Id = Guid.NewGuid();
    public Aircraft? IsBusyWithAircraft { get; set; }

    public bool CheckIsActive()
    {
        bool result = false;
        if (this.IsBusyWithAircraft != null)
        {
            result = this.IsBusyWithAircraft.IsTakingOff;
        }
        return result;
    }

    public void HighLightRed()
    {
        Console.WriteLine($"Runway {this.Id} is busy!");
    }

    public void HighLightGreen()
    {
        Console.WriteLine($"Runway {this.Id} is free!");
    }
}