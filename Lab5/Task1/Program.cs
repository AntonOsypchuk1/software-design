using Task1.LightHTML;
using Task1.LightHTML.Elements;

namespace Task1;

internal static class Program
{
    static void Main(string[] args)
    {
        var page = new LightHtmlPage(new LightElementNode("div"));
        var container = new LightElementNode("ul");
        container.AddClass("container");
        page.Root.AppendChild(container);

        var li1 = new LightElementNode("li", true);
        li1.AppendChild(new LightTextNode("Item 1"));
        var li2 = new LightElementNode("li", true);
        li2.AppendChild(new LightTextNode("Item 2"));
        var li3 = new LightElementNode("li", true);
        li3.AppendChild(new LightTextNode("Item 3"));
        container.AppendChild(li1);
        container.AppendChild(li2);
        container.AppendChild(li3);

        Console.WriteLine(container.OuterHtml);
        Console.WriteLine(container.InnerHtml);

        page.Render();

        var clonePage = page.Clone();
        clonePage.Render();
    }
}