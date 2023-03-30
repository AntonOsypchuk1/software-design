using ConsoleApp.GraphicEditor.renderer;

namespace ConsoleApp.GraphicEditor;

public abstract class Shape
{
    protected IRenderer renderer;

    public Shape(IRenderer renderer)
    {
        this.renderer = renderer;
    }

    public abstract void Draw();
}