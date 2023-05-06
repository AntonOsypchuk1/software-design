namespace Task2.Composite;

public class ArtefactContainer : Artefact
{
    private List<Artefact> _artefacts = new List<Artefact>();

    public ArtefactContainer(string name, int weight, int powerBuff) : base(name, weight, powerBuff)
    {
    }

    public void AddArtefact(Artefact artefact)
    {
        this._artefacts.Add(artefact);
        Console.WriteLine($"Added {artefact.Name} to {this.Name}");
    }

    public void RemoveArtefact(Artefact artefact)
    {
        this._artefacts.Remove(artefact);
        Console.WriteLine($"Removed {artefact.Name} to {this.Name}");
    }

    public override int GetWeight()
    {
        return this._artefacts.Aggregate(
            this._weight, (sum, next) => sum += next.GetWeight());
    }

    public override int GetPowerBuf()
    {
        return this._artefacts.Aggregate(
            this._powerBuf, (sum, next) => sum += next.GetPowerBuf());
    }

    public override int GetCount()
    {
        return this._artefacts.Aggregate(
            0, (sum, next) => sum += next.GetCount());
    }
}