using Task1.LightHTML;
using Task1.LightHTML.Elements;
using Task1.LightHTML.Elements.Image.LoadingStrategy;
using Task1.LightHTML.Elements.Image;
using Task1.LightHTML.Styles;
using Task1.LightHTML.Search;

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
        Image();
        Dfs();
        Bfs();

        void Dfs()
        {
            // DepthFirstSearch strategy
            var dfs = new DepthFirstSearch();
            var predicate = new Func<LightNode, bool>(node =>
                node is LightElementNode elementNode && elementNode.TagName == "div");
            var result = dfs.Search(root, predicate);

            if (result)
            {
                Console.WriteLine("Found the first <div> element!");
            }
            else
            {
                Console.WriteLine("Did not find the first <div> element.");
            }

            var matchingElements = dfs.FindAll(root, node => node.TagName == "p");
            foreach (var element in matchingElements)
            {
                Console.WriteLine(element.OuterHtml);
            }
        }

        void Bfs()
        {
            // BreadthFirstSearch strategy
            var bfs = new DepthFirstSearch();
            var predicate = new Func<LightNode, bool>(node =>
                node is LightElementNode elementNode && elementNode.TagName == "div");
            var result = bfs.Search(root, predicate);

            if (result)
            {
                Console.WriteLine("Found the first <div> element!");
            }
            else
            {
                Console.WriteLine("Did not find the first <div> element.");
            }

            var matchingElements = bfs.FindAll(root, node => node.TagName == "div");
            foreach (var element in matchingElements)
            {
                Console.WriteLine(element.OuterHtml);
            }
        }

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

        void Image()
        {
            // Test cases for image loading classes
            // Load image from the file system
            var imageNode = new LightImageNode("../../../LightHTML/Elements/Image/src/gray.png", new LightFilesystemImageLoading());
            var imageBytes = imageNode.LoadImage();
            Console.WriteLine(imageBytes.ToString());

            // Load image from the file system
            string path = "https://i.natgeofe.com/n/548467d8-c5f1-4551-9f58-6817a8d2c45e/NationalGeographic_2572187_square.jpg";
            var imageNode2 = new LightImageNode($"{path}", new LightNetworkImageLoading());
            var imageBytes2 = imageNode2.LoadImage();
            Console.WriteLine(imageBytes2.ToString());
            // idk how to open the image in console but we can see that it reads the bytes of all the files...
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