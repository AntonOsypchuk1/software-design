namespace Factory.SubscriptionFactory;

public class EducationalSubscription : Subscription
{
    public EducationalSubscription()
    {
        Name = "Educational";
        MonthlyFee = 19.99m;
        SubscriptionPeriod = 30;
        Channels = new List<string> {"Discovery", "TET", "ICTV"};
        Features = new List<string> {"HD Streaming", "10 Devices at Once", "Offline Viewing"};
    }
}