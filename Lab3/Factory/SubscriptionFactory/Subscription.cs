namespace Factory.SubscriptionFactory;

public abstract class Subscription
{
    public string Name { get; protected set; }
    public decimal MonthlyFee { get; protected set; }
    public int SubscriptionPeriod { get; protected set; }
    public List<string> Channels { get; protected set; }
    public List<string> Features { get; protected set; }
}