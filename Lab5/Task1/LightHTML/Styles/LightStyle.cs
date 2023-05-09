using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Task1.LightHTML.Styles;

public class LightStyle : ILightStylePrototype
{
    private static Dictionary<string, LightStyle> _instances = new Dictionary<string, LightStyle>();

    // Here are the styles that this instance of LightStyle represents
    public string? BackgroundColor { get; set; }
    public string? Color { get; set; }
    public string? Font { get; set; }
    public int? FontSize { get; set; }
    public string? Padding { get; set; }
    public string? Border { get; set; }
    public string? Cursor { get; set; }
    // ...

    public LightStyle Clone()
    {
        LightStyle newStyle = new LightStyle();
        newStyle.BackgroundColor = BackgroundColor;
        newStyle.Color = Color;
        newStyle.Font = Font;
        newStyle.FontSize = FontSize;
        newStyle.Border = Border;
        newStyle.Padding = Padding;
        newStyle.Cursor = Cursor;
        // ...

        return newStyle;
    }

    public static LightStyle GetInstance(string? backgroundColor, string? color, string? font, int? fontSize,
        string? cursor, string? padding, string? border /*, ...*/)
    {
        // Generate a unique key for the combination of style properties.
        string key = $"{backgroundColor}-{color}-{font}-{fontSize}-{cursor}-{padding}-{border}" /*-...*/;

        if (_instances.ContainsKey(key))
        {
            return _instances[key];
        }

        LightStyle newStyle = new LightStyleBuilder()
            .SetFont(font)
            .SetFontSize(fontSize)
            .SetColor(color)
            .SetBackgroundColor(backgroundColor)
            .SetPadding(padding)
            .SetBorder(border)
            .SetCursor(cursor)
            .Build();
        _instances.Add(key, newStyle);

        return newStyle;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        if (!string.IsNullOrEmpty(BackgroundColor))
        {
            builder.Append($"background-color: {BackgroundColor}; ");
        }

        if (!string.IsNullOrEmpty(Color))
        {
            builder.Append($"color: {Color}; ");
        }

        if (!string.IsNullOrEmpty(Font))
        {
            builder.Append($"font-family: {Font}; ");
        }

        if (!string.IsNullOrEmpty(Padding))
        {
            builder.Append($"padding: {Padding}; ");
        }

        if (!string.IsNullOrEmpty(Border))
        {
            builder.Append($"border: {Border}; ");
        }

        if (!string.IsNullOrEmpty(Cursor))
        {
            builder.Append($"cursor: {Cursor}; ");
        }

        if (FontSize != null)
        {
            builder.Append($"font-size: {FontSize}; ");
        }
        // ...

        return builder.ToString().TrimEnd(' ', ';');
    }
}