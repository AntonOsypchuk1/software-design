namespace Solid.Warehouse;

// Dependency Inversion Principle:
// High-level modules should not depend on low-level
// modules. Both should depend on abstractions.

public class Warehouse : IInventoryReportable, IReceiptRegistrable, IShipmentRegistrable
{
    private Product[] _products;
    private DateTime _lastDeliveryDate;

    public Warehouse(Product[] products, DateTime lastDeliveryDate)
    {
        _products = products;
        _lastDeliveryDate = lastDeliveryDate;
    }

    public void GenerateInventoryReport()
    {
        Console.WriteLine("Current inventory:");

        foreach (var product in _products)
        {
            Console.WriteLine($"{product.Name}: " +
                              $"{product.Price.Currency.Symbol}{product.Price.WholePart}.{product.Price.Pennies:D2} " +
                              $"{product.Price.Currency.Symbol}{product.Price.WholePart * 100 + (product.Price.Pennies / 100.0)}" +
                              $"per {product.UnitOfMeasurement}, {product.Quantity} {product.UnitOfMeasurement} left");
        }
    }

    public void RegisterReceipt(Product product, int quantity)
    {
        var existingProduct = _products.FirstOrDefault(p => p.Name == product.Name);

        if (existingProduct != null)
        {
            existingProduct.Quantity -= quantity;
        }
        else
        {
            var newProducts = new List<Product>(_products);
            newProducts.Add(product);
            _products = newProducts.ToArray();
        }
    }

    public void RegisterShipment(Product product, int quantity)
    {
        var existingProduct = _products.FirstOrDefault(p => p.Name == product.Name);

        if (existingProduct != null && existingProduct.Quantity >= quantity)
        {
            existingProduct.Quantity -= quantity;
        }
        else
        {
            throw new Exception("Insufficient inventory");
        }
    }
}