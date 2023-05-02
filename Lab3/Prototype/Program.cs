

using Prototype.Virus;

var virus1 = new Virus(10, 5, "Virus 1", "Type A", null);

var virusChild1 = new VirusChild(1, 0, "VChild 1", "Type A", null, new DateTime(2023, 5, 1), virus1);
// var virusChild2 = new VirusChild(1, 1, "VChild 2", "Type A", null, new DateTime(2022, 5, 1), virus1);
var virusChild2 = (VirusChild)virusChild1.Clone();
// virus1.AppendChild(virusChild1);
// virus1.AppendChild(virusChild2);

var virus2 = (Virus)virus1.Clone();

Console.WriteLine($"Virus 1 and Virus 2 are equal: {virus1 == virus2}");
Console.WriteLine($"Virus 1 and Virus 2 have the same Children: {virus1.Children == virus2.Children}");
Console.WriteLine($"VirusChild 1 and VirusChild 2 are equal: {virusChild1 == virusChild2}");
Console.WriteLine($"VirusChild 1 and VirusChild 2 have the same Parent: {virusChild1.Parent == virusChild2.Parent}");