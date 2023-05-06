namespace Task1.LightHTML;

public class LightHtmlPage
{
    public LightElementNode Root { get; }

    public LightHtmlPage(LightElementNode root)
    {
        Root = root;
    }

    public void Render()
    {
        Root.Render();
    }

    public LightHtmlPage Clone()
    {
        var cloneRoot = CloneElementNode(Root) as LightElementNode;
        return new LightHtmlPage(cloneRoot);
    }

    public LightNode CloneNode(LightNode node)
    {
        if (node is LightTextNode textNode)
        {
            return new LightTextNode(textNode.Text);
        }
        else if (node is LightElementNode elementNode)
        {
            var clone = new LightElementNode(elementNode.TagName, elementNode.IsBlock, elementNode.IsSelfClosing);
            clone.CssClasses.AddRange(elementNode.CssClasses);
            foreach (var child in elementNode.Children)
            {
                clone.AppendChild(CloneNode(child));
            }

            return clone;
        }
        throw new ArgumentException($"Unsupported node type: {node.GetType().Name}", nameof(node));
    }

    public LightNode CloneElementNode(LightElementNode elementNode)
    {
        return CloneNode(elementNode);
    }
}