using System.ComponentModel;

namespace Prototype.Virus;

public class VirusChild : Virus, ICloneable
{
    public DateTime BirthDate { get; set; }
    public Virus? Parent { get; set; }

    public VirusChild(double weight, int age, string name, string species, VirusChild[]? children, DateTime birthDate, Virus parent)
    : base(weight, age, name, species, children)
    {
        BirthDate = birthDate;
        Parent = parent;
        parent.AppendChild(this);
    }

    public VirusChild(double weight, int age, string name, string species, VirusChild[]? children, VirusChild other)
    : base(weight, age, name, species, children)
    {
        Weight = other.Weight;
        Age = other.Age;
        Name = other.Name;
        Species = other.Species;
        Children = other.Children;
        BirthDate = other.BirthDate;
        Parent = null;
    }

    public new object Clone()
    {
        return new VirusChild(Weight, Age, Name, Species, Children, this);
    }
}