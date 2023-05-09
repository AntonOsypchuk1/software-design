namespace Task1.LightHTML.Events;

public class LightEvent
{
    public string Type { get; private set; }
    public object Data { get; private set; }

    public LightEvent(string type, object data)
    {
        Type = type;
        Data = data;
    }
}