namespace ConsoleApp.GraphicEditor.renderer;

public class RasterRenderer : IRenderer
{
    public void Render(string shape)
    {
        Console.WriteLine(shape + " as pixels");
    }
}