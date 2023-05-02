namespace Agent.AirTrafficControl;

public class CommandCentre
{
    private List<Runway> _runways = new List<Runway>();
    private List<Aircraft> _aircrafts = new List<Aircraft>();

    public CommandCentre()
    {
    }

    public void RegisterAircraft(Aircraft aircraft)
    {
        _aircrafts.Add(aircraft);
    }

    public void RegisterRunways(Runway runway)
    {
        _runways.Add(runway);
    }

    public bool RequestToLand(Aircraft aircraft)
    {
        Console.WriteLine($"Aircraft {aircraft.Name} is requesting permission to land.");
        foreach (Runway runway in _runways)
        {
            if (runway.IsBusyWithAircraft == null)
            {
                Console.WriteLine($"Permission granted. Aircraft {aircraft.Name} is landing on runway {runway.Id}");
                runway.IsBusyWithAircraft = aircraft;
                aircraft.CurrentRunway = runway;
                return true;
            }
        }
        Console.WriteLine($"Could not grant permission to land. All runways are busy.");
        return false;
    }

    public void RequestToTakeOff(Aircraft aircraft)
    {
        Console.WriteLine($"Aircraft {aircraft.Name} is requesting permission to take off from runway {aircraft.CurrentRunway?.Id}.");
        aircraft.CurrentRunway?.HighLightGreen();
        aircraft.CurrentRunway.IsBusyWithAircraft = null;
        aircraft.CurrentRunway = null;
        Console.WriteLine($"Permission granted. Aircraft {aircraft.Name} has taken off.");
    }
}