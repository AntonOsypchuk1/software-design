using System.Text;

namespace Task1.LightHTML;

public class LightTextNode : LightNode
{
    public string Text { get; }
    
    public LightTextNode(string text)
    {
        Text = text;
    }
    
    public override string OuterHtml => Text;

    public override void Render(int indentLevel = 0)
    {
        Console.WriteLine($"{new string(' ', indentLevel)}{Text}");
    }
}