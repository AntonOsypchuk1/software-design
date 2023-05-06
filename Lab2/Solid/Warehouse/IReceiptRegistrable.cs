namespace Solid.Warehouse;

public interface IReceiptRegistrable
{
    void RegisterReceipt(Product product, int quantity);
}