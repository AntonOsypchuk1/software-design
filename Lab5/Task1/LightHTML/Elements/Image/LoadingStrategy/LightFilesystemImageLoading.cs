namespace Task1.LightHTML.Elements.Image.LoadingStrategy;

public class LightFilesystemImageLoading : LightImageLoading
{
    public override byte[] LoadImage(string href)
    {
        // Load image from the file system
        return File.ReadAllBytes(href);
    }
}