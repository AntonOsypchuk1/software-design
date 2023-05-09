using Task1.LightHTML.Elements;

namespace Task1.LightHTML.Events.MyButton;

public class MyButtonClickListener : LightEventListener
{
    public override void HandleEvent(LightEvent e)
    {
        if (e.Type == "click")
        {
            Console.WriteLine("Button clicked!");
        }
    }
}