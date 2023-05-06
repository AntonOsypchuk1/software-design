using System.Transactions;

namespace Task2.Composite;

public class MarvelHero
{
    public event EventHandler<AddArtefactEventArgs> AddArtefactEventArgs; 
    public event EventHandler<RemoveArtefactEventArgs> RemoveArtefactEventArgs; 
    private List<Artefact> _artefacts = new List<Artefact>();
    private List<MarvelHero> _friends = new List<MarvelHero>();
    public string Name { get; private set; }

    private int _power;

    public MarvelHero(string name, int power)
    {
        this.Name = name;
        this._power = power;
    }

    public void AddArtefact(Artefact artefact, bool log = false)
    {
        this._artefacts.Add(artefact);
    }
    
    public void AddFriend(MarvelHero friend)
    {
        this._friends.Add(friend);
    }

    public void RemoveArtefact(Artefact artefact)
    {
        this._artefacts.Remove(artefact);
    }
    
    public void RemoveFriend(MarvelHero friend)
    {
        this._friends.Remove(friend);
    }

    public void Strike()
    {
        int totalPower = this._artefacts.Aggregate(this._power, (sum, next) => sum += next.GetPowerBuf());
        Console.WriteLine($"{this.Name} hits with power {totalPower}");
    }

    public void CalculateArtefactsWeight()
    {
        int totalArtefactsWeight = this._artefacts.Aggregate(0, (sum, next) => sum += next.GetWeight());
        Console.WriteLine($"Total artefacts weight: {totalArtefactsWeight}");
    }

    public void CountArtefacts()
    {
        int totalArtefactCount = this._artefacts.Count;
        Console.WriteLine($"{this.Name} has {totalArtefactCount} artefacts");
    }
}