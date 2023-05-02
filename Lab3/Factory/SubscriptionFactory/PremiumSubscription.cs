namespace Factory.SubscriptionFactory;

public class PremiumSubscription : Subscription
{
    public PremiumSubscription()
    {
        Name = "Premium";
        MonthlyFee = 29.99m;
        SubscriptionPeriod = 365;
        Channels = new List<string> {"HBO", "1st Channel", "New Channel"};
        Features = new List<string> {"4k Streaming", "Unlimited Devices", "Downloadable Content"};
    }
}