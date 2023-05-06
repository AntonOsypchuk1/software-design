

using Solid;
using Solid.Warehouse;

var dollar = new Dollar();

Product apple = new Product(
    "Apple",
    new Money(1, 25, dollar),
    "kg",
    125);

Product banana = new Product(
    "Banana",
    new Money(2, 50, dollar),
    "kg",
    150);

Product orange = new Product(
    "Orange",
    new Money(1, 75, dollar),
    "kg",
    175);

Product[] products = { apple, banana, orange };
Warehouse warehouse = new Warehouse(products, DateTime.Now);

warehouse.GenerateInventoryReport();
warehouse.RegisterReceipt(orange, 25);
warehouse.RegisterShipment(apple, 50);

apple.ReducePrice(50);

warehouse.GenerateInventoryReport();