namespace Solid.Warehouse;

// Interface Segregation Principle:
// Interface should be tailored to the needs of the client,
// not the implementation.

public interface IInventoryReportable
{
    void GenerateInventoryReport();
}