namespace ConsoleApp.BigMac;

public class Prices
{
    public decimal BigMacPrice => new Menu.BigMac().Price;
    public decimal ChickenNuggetsPrice => new Menu.ChickenNuggets().Price;
    public decimal FriesPrice => new Menu.Fries().Price;
    public decimal CokePrice => new Menu.Coke().Price;
    public decimal SpritePrice => new Menu.Sprite().Price;
}