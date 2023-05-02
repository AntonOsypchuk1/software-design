namespace Prototype.Virus;

public class Virus : ICloneable
{
    public double Weight { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public VirusChild[]? Children { get; set; }

    public Virus(double weight, int age, string name, string species, VirusChild[]? children)
    {
        Weight = weight;
        Age = age;
        Name = name;
        Species = species;
        Children = children;
    }

    public void AppendChild(VirusChild child)
    {
        if (Children == null)
        {
            Children = new[] {child};
        }
        else
        {
            Children.Append(child);
        }
        child.Parent = this;
    }
    
    public object Clone()
    {
        return new Virus(Weight, Age, Name, Species, null);
    }
}