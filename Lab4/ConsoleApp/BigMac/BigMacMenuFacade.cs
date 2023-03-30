namespace ConsoleApp.BigMac;

public class BigMacMenuFacade
{
    private readonly Prices _prices;

    public BigMacMenuFacade()
    {
        _prices = new Prices();
    }

    public string GetMenu()
    {
        return $"- {new Menu.BigMac().Name} (${_prices.BigMacPrice})\n" +
               $"- {new Menu.ChickenNuggets().Name} (${_prices.ChickenNuggetsPrice})\n" +
               $"- {new Menu.Fries().Name} (${_prices.FriesPrice})\n" +
               $"- {new Menu.Coke().Name} (${_prices.CokePrice})\n" +
               $"- {new Menu.Sprite().Name} (${_prices.SpritePrice})\n";
    }

    public string OrderBigMacMeal()
    {
        var meal = new Menu.BigMac().Name + " meal:\n";
        meal += $"- {new Menu.BigMac().Name}\n";
        meal += $"- {new Menu.Fries().Name}\n";
        meal += $"- {new Menu.Coke().Name}\n";
        meal += $"- {new Packaging.Box().Name}\n";
        meal += $"- {new Packaging.Napkin().Name}\n";
        meal += $"Total price: ${_prices.BigMacPrice + _prices.FriesPrice + _prices.CokePrice}\n";
        return meal;
    }
    
    public string OrderChickenNuggetsMeal()
    {
        var meal = new Menu.ChickenNuggets().Name + " meal:\n";
        meal += $"- {new Menu.ChickenNuggets().Name}\n";
        meal += $"- {new Menu.Fries().Name}\n";
        meal += $"- {new Menu.Coke().Name}\n";
        meal += $"- {new Packaging.Box().Name}\n";
        meal += $"- {new Packaging.Napkin().Name}\n";
        meal += $"Total price: ${_prices.ChickenNuggetsPrice + _prices.FriesPrice + _prices.CokePrice}\n";
        return meal;
    }
}