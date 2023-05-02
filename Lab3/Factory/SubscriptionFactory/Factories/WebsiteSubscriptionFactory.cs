namespace Factory.SubscriptionFactory.Factories;

public class WebsiteSubscriptionFactory : SubscriptionFactory
{
    public override Subscription CreateSubscription()
    {
        return new DomesticSubscription();
    }
}