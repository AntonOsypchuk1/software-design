using Factory.SubscriptionFactory;
using Factory.SubscriptionFactory.Factories;

SubscriptionFactory websiteFactory = new WebsiteSubscriptionFactory();
Subscription domesticSubscription = websiteFactory.CreateSubscription();
Console.WriteLine($"Created {domesticSubscription.Name} subscription with monthly fee {domesticSubscription.MonthlyFee:C}.");

SubscriptionFactory mobileFactory = new MobileAppSubscriptionFactory();
Subscription educationalSubscription = mobileFactory.CreateSubscription();
Console.WriteLine($"Created {educationalSubscription.Name} subscription with monthly fee {educationalSubscription.MonthlyFee:C}.");

SubscriptionFactory managerFactory = new ManagerCallSubscriptionFactory();
Subscription premiumSubscription = managerFactory.CreateSubscription();
Console.WriteLine($"Created {premiumSubscription.Name} subscription with monthly fee {premiumSubscription.MonthlyFee:C}.");