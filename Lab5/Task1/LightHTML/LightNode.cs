using System.Reflection.Metadata;
using System.Text;

namespace Task1.LightHTML;

public abstract class LightNode
{
    public LightNode Parent { get; private set; }

    public List<LightNode> Children { get; } = new List<LightNode>();

    public virtual string OuterHtml => string.Empty;

    public virtual string InnerHtml => string.Empty;

    public virtual void AppendChild(LightNode node)
    {
        if (node == null)
        {
            throw new ArgumentNullException(nameof(node));
        }

        node.RemoveFromParent();
        Children.Add(node);
        node.Parent = this;
    }

    public virtual void SetParent(LightNode node)
    {
        Parent = node;
    }

    public void RemoveChild(LightNode node)
    {
        if (node == null)
        {
            throw new ArgumentNullException(nameof(node));
        }

        if (node.Parent != this)
        {
            throw new ArgumentException("The specified node is not a child of this node.", nameof(node));
        }

        Children.Remove(node);
        node.Parent = null;
    }

    public void InsertBefore(LightNode node, LightNode refNode)
    {
        if (node == null)
        {
            throw new ArgumentNullException(nameof(node));
        }

        if (refNode == null)
        {
            throw new ArgumentNullException(nameof(refNode));
        }

        if (refNode.Parent != this)
        {
            throw new ArgumentException("The specified reference node is not a child of this node.", nameof(refNode));
        }

        node.RemoveFromParent();
        int index = Children.IndexOf(refNode);
        Children.Insert(index, node);
        node.Parent = this;
    }

    public void RemoveFromParent()
    {
        if (Parent != null)
        {
            Parent.RemoveChild(this);
        }
    }

    public virtual void Render(int indentLevel = 0)
    {
        // Console.WriteLine($"{new string(' ', indentLevel)}{OuterHtml}");
        foreach (var child in Children)
        {
            child.Render(indentLevel + 2);
        }
    }
}