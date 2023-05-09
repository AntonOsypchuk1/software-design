using System.Diagnostics.CodeAnalysis;
using Task1.LightHTML.Styles;

namespace Task1.LightHTML.Elements;

public class LightElementNode : LightNode
{
    public string TagName { get; }
    public bool IsBlock { get; }
    public bool IsSelfClosing { get; }
    public LightStyle? Styles { get; private set; } = new LightStyle();
    public List<string> CssClasses { get; } = new List<string>();

    public override string OuterHtml => IsSelfClosing
        ? $"<{TagName}{GetClassAttribute()}{GetStyles()} />"
        : $"<{TagName}{GetClassAttribute()}{GetStyles()}>{InnerHtml}</{TagName}>";

    public override string InnerHtml => string.Join(string.Empty, Children.Select(c => c.OuterHtml));

    public LightElementNode(string tagName, bool isBlock = false, bool isSelfClosing = false)
    {
        TagName = tagName;
        IsBlock = isBlock;
        IsSelfClosing = isSelfClosing;
    }

    public virtual void ApplyStyles(LightStyle style)
    {
        this.Styles = style;
    }

    public void AddClass(string className)
    {
        CssClasses.Add(className);
    }

    private string GetStyles()
    {
        var styles = Styles.ToString();
        return styles.Any()
            ? $" style=\"{styles}\""
            : string.Empty;
    }

    private string GetClassAttribute()
    {
        return CssClasses.Any()
            ? $" class=\"{string.Join(" ", CssClasses)}\""
            : string.Empty;
    }

    public void ReplaceChild(LightNode node, LightNode replacement)
    {
        if (node == null)
        {
            throw new ArgumentNullException(nameof(node));
        }

        if (replacement == null)
        {
            throw new ArgumentNullException(nameof(replacement));
        }

        if (node.Parent != this)
        {
            throw new ArgumentException("The specified node is not a child of this node.", nameof(node));
        }

        replacement.RemoveFromParent();
        int index = Children.IndexOf(node);
        Children[index] = replacement;
        replacement.SetParent(this);
    }

    public override void Render(int indentLevel = 0)
    {
        foreach (var child in Children)
        {
            child.Render(indentLevel + 2);
        }
    }
}