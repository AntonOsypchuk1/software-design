using ConsoleApp.GraphicEditor.renderer;

namespace ConsoleApp.GraphicEditor;

// bridge class to connect Shape and IRenderer
public class Bridge
{
    public static void Run(IRenderer renderer)
    {
        var circle = new Circle(renderer);
        var square = new Square(renderer);
        var triangle = new Triangle(renderer);
        
        circle.Draw();
        square.Draw();
        triangle.Draw();
    }
}