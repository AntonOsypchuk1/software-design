using Task1.LightHTML.Elements.Image.LoadingStrategy;

namespace Task1.LightHTML.Elements.Image;

public class LightImageNode : LightNode
{
    private readonly LightImageLoading _loading;
    public string Href { get; }

    public LightImageNode(string href, LightImageLoading loading)
    {
        _loading = loading;
        Href = href;
    }

    public override string OuterHtml => $"<img src=\"{Href}\">";
    
    public override string InnerHtml => string.Empty;

    public byte[] LoadImage()
    {
        return _loading.LoadImage(Href);
    }
}