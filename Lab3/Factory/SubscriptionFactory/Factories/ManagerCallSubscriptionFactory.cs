namespace Factory.SubscriptionFactory.Factories;

public class ManagerCallSubscriptionFactory : SubscriptionFactory
{
    public override Subscription CreateSubscription()
    {
        return new PremiumSubscription();
    }
}