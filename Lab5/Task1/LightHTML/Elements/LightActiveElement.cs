using Task1.LightHTML.Events;
using Task1.LightHTML.Styles;

namespace Task1.LightHTML.Elements;

public class LightActiveElement : LightElementNode
{
    private readonly List<LightEventListener> _listeners = new List<LightEventListener>();
    private readonly LightElementTemplate _template;

    public LightActiveElement(string tagName, LightElementTemplate template)
        : base(tagName)
    {
        _template = template;
        _template.OnCreated(this);
    }

    public void AddEventListener(LightEventListener listener)
    {
        _listeners.Add(listener);
    }

    public void RemoveEventListener(LightEventListener listener)
    {
        _listeners.Remove(listener);
    }

    public void FireEvent(string type, object data = null)
    {
        var e = new LightEvent(type, data);
        foreach (var listener in _listeners)
        {
            listener.HandleEvent(e);
        }
    }
    
    public override void ApplyStyles(LightStyle style)
    {
        base.ApplyStyles(style);
        _template.OnStylesApplied(this);
    }

    public override void AppendChild(LightNode child)
    {
        base.AppendChild(child);
        if (child is LightActiveElement element)
        {
            _template.OnInserted(element);
        }
    }
}