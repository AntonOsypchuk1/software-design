using Task1.LightHTML.Elements;

namespace Task1.LightHTML.Events;

public abstract class LightElementTemplate
{
    public virtual void OnCreated(LightActiveElement elementNode) {}
    public virtual void OnInserted(LightActiveElement elementNode) {}
    public virtual void OnRemoved(LightActiveElement elementNode) {}
    public virtual void OnStylesApplied(LightActiveElement elementNode) {}
}