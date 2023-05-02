using System.Security.Cryptography;

namespace Factory.SubscriptionFactory;

public class DomesticSubscription : Subscription
{
    public DomesticSubscription()
    {
        Name = "Domestic";
        MonthlyFee = 9.99m;
        SubscriptionPeriod = 30;
        Channels = new List<string> {"ABC", "NBC", "CBS"};
        Features = new List<string> {"HD Streaming", "3 Devices at Once"};
    }    
}