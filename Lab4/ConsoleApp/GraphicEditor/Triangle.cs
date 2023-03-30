using ConsoleApp.GraphicEditor.renderer;

namespace ConsoleApp.GraphicEditor;

public class Triangle : Shape
{
    public Triangle(IRenderer renderer) : base(renderer)
    {
    }

    public override void Draw()
    {
        renderer.Render("Drawing Triangle");
    }
}