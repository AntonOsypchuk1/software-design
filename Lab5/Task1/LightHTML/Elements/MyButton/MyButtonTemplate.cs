using Task1.LightHTML.Elements;
using Task1.LightHTML.Styles;

namespace Task1.LightHTML.Events.MyButton;

public class MyButtonTemplate : LightElementTemplate
{
    public override void OnCreated(LightActiveElement elementNode)
    {
        // Default styles
        elementNode.ApplyStyles(
            new LightStyleBuilder()
                .SetBackgroundColor("#cccccc")
                .SetColor("#000000")
                .SetPadding("5px 10px")
                .SetCursor("pointer")
                .SetBorder("none")
                .Build());
    }
}