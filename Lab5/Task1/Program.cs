using Task1.LightHTML;
using Task1.LightHTML.Elements;
using Task1.LightHTML.Styles;

namespace Task1;

internal static class Program
{
    static void Main(string[] args)
    {
        // Create some test HTML
        var root = new LightElementNode("html");
        var head = new LightElementNode("head");
        var title = new LightElementNode("title");
        var body = new LightElementNode("body");
        var div1 = new LightElementNode("div");
        var div2 = new LightElementNode("div");
        var p1 = new LightElementNode("p");
        var p2 = new LightElementNode("p");
        var p3 = new LightElementNode("p");

        root.AppendChild(head);
        head.AppendChild(title);
        root.AppendChild(body);
        body.AppendChild(div1);
        div1.AppendChild(div2);
        div2.AppendChild(p1);
        div2.AppendChild(p2);
        div2.AppendChild(p3);

        title.AppendChild(new LightTextNode("Test HTML"));
        p1.AppendChild(new LightTextNode("This is a test."));
        p2.AppendChild(new LightTextNode("This is only a test."));
        p3.AppendChild(new LightTextNode("Testing, testing, 1, 2, 3."));

        Styles();
        StartProgram();

        void Styles()
        {
            // Styles implementation with builder and flyWeight patterns
            var style = new LightStyleBuilder()
                .SetFont("Arial")
                .SetFontSize(12)
                .SetColor("#000000")
                .SetBackgroundColor("#FFFFFF")
                .Build();

            div1.ApplyStyles(style);
            Console.WriteLine(div1.Styles.Color);

            Console.WriteLine(div1.OuterHtml);
        }

        void StartProgram()
        {
            // Lab 5 program.cs

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
}