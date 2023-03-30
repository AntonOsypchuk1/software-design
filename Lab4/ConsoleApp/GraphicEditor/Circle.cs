using ConsoleApp.GraphicEditor.renderer;

namespace ConsoleApp.GraphicEditor;

public class Circle : Shape
{
    public Circle(IRenderer renderer) : base(renderer)
    {
    }

    public override void Draw()
    {
        renderer.Render("Drawing Circle");
    }
}