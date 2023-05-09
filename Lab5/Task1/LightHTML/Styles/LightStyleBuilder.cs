namespace Task1.LightHTML.Styles;

public class LightStyleBuilder
{
    private LightStyle _style;

    public LightStyleBuilder()
    {
        _style = new LightStyle();
    }

    public LightStyleBuilder SetFont(string? font)
    {
        _style.Font = font;
        return this;
    }

    public LightStyleBuilder SetFontSize(int? fontSize)
    {
        _style.FontSize = fontSize;
        return this;
    }
    
    public LightStyleBuilder SetColor(string? color)
    {
        _style.Color = color;
        return this;
    }
    
    public LightStyleBuilder SetBackgroundColor(string? backgroundColor)
    {
        _style.BackgroundColor = backgroundColor;
        return this;
    }

    public LightStyleBuilder SetBorder(string? border)
    {
        _style.Border = border;
        return this;
    }
    
    public LightStyleBuilder SetPadding(string? padding)
    {
        _style.Padding = padding;
        return this;
    }
    
    public LightStyleBuilder SetCursor(string? cursor)
    {
        _style.Cursor = cursor;
        return this;
    }

    public LightStyle Build()
    {
        return _style;
    }
}