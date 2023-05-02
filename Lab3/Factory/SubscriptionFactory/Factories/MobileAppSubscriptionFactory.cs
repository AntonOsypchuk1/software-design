namespace Factory.SubscriptionFactory.Factories;

public class MobileAppSubscriptionFactory : SubscriptionFactory
{
    public override Subscription CreateSubscription()
    {
        return new EducationalSubscription();
    }
}