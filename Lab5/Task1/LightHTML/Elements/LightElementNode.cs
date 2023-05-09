using System.Text;
using System.Text.Json.Serialization.Metadata;

namespace Task1.LightHTML.Elements;

public class LightElementNode : LightNode
{
    public string TagName { get; }

    public bool IsBlock { get; }

    public bool IsSelfClosing { get; }

    public List<string> CssClasses { get; } = new List<string>();

    public override string OuterHtml => IsSelfClosing
        ? $"<{TagName}{GetClassAttribute()} />"
        : $"<{TagName}{GetClassAttribute()}>{InnerHtml}</{TagName}>";

    public override string InnerHtml => string.Join(string.Empty, Children.Select(c => c.OuterHtml));

    public LightElementNode(string tagName, bool isBlock = false, bool isSelfClosing = false)
    {
        TagName = tagName;
        IsBlock = isBlock;
        IsSelfClosing = isSelfClosing;
    }

    public void AddClass(string className)
    {
        CssClasses.Add(className);
    }

    private string GetClassAttribute()
    {
        return CssClasses.Any()
            ? $" class=\"{string.Join(" ", CssClasses)}\""
            : string.Empty;
    }
}