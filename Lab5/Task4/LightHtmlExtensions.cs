using Task1.LightHTML;
using Task1.LightHTML.Elements;

namespace Task4;

public static class LightHtmlExtensions
{
    public static LightElementNode ToHeader(this string text, int level)
    {
        var tagName = $"h{level}";
        return new LightElementNode(tagName)
        {
            Children = {new LightTextNode(text)}
        };
    }

    public static LightElementNode ToParagraph(this string text)
    {
        return new LightElementNode("p")
        {
            Children = {new LightTextNode(text)}
        };
    }

    public static LightElementNode ToBlockQuote(this string text)
    {
        return new LightElementNode("blockquote")
        {
            Children = {new LightTextNode(text)}
        };
    }

    public static LightHtmlPage ToHtmlPage(this string[] lines)
    {
        var root = new LightElementNode("div");
        LightElementNode currentParent = root;

        foreach (var line in lines)
        {
            var trimmedLine = line.Trim();
            LightElementNode node;

            if (trimmedLine.Length < 20)
            {
                node = trimmedLine.ToHeader(2);
            }
            else if (trimmedLine.StartsWith(" "))
            {
                node = trimmedLine.ToBlockQuote();
            }
            else
            {
                node = trimmedLine.ToParagraph();
            }
            
            currentParent.AppendChild(node);

            if (node.IsBlock)
            {
                currentParent = node;
            }
        }

        return new LightHtmlPage(root);
    }
}