namespace Task2.Composite;

public class AddArtefactEventArgs : EventArgs
{
    public Artefact Artefact { get; }

    public AddArtefactEventArgs(Artefact artefact)
    {
        this.Artefact = artefact;
    }
}

public class RemoveArtefactEventArgs : EventArgs
{
    public Artefact Artefact { get; }

    public RemoveArtefactEventArgs(Artefact artefact)
    {
        this.Artefact = artefact;
    }
}