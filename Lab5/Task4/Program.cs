

using System.Runtime.CompilerServices;
using Task1.LightHTML;
using Task1.LightHTML.Elements;
using Task4;

var text = File.ReadAllLines("../../../book.txt");
var htmlPage = text.ToHtmlPage();
Console.WriteLine(htmlPage.Root.OuterHtml);

var memoryUsage = CalculateMemoryUsage(htmlPage.Root);
Console.WriteLine($"Memory usage: {memoryUsage / 1024.0} KB");

static long CalculateMemoryUsage(LightNode node)
{
    long size = 0;

    if (node is LightTextNode textNode)
    {
        size += sizeof(char) * textNode.Text.Length;
    }
    else if (node is LightElementNode elementNode)
    {
        size += sizeof(char) * elementNode.TagName.Length;
        size += sizeof(bool) * 2;
        size += sizeof(int) * 2;
        size += sizeof(long) * elementNode.CssClasses.Count;
        size += sizeof(long) * elementNode.Children.Count;
        foreach (var child in elementNode.Children)
        {
            size += CalculateMemoryUsage(child);
        }
    }

    return size;
}