namespace ConsoleApp.GraphicEditor.renderer;

public class VectorRenderer : IRenderer
{
    public void Render(string shape)
    {
        Console.WriteLine(shape + " as vector");
    }
}