namespace Solid.Warehouse;

public interface IShipmentRegistrable
{
    void RegisterShipment(Product product, int quantity);
}