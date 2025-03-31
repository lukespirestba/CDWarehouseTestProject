namespace TestProject;

public class WarehouseTest
{
    [Test]
    public void CDIsBoughtAndStockDecrements()
    {
        Warehouse warehouse = new Warehouse();
        warehouse.BuyCD();

        Assert.AreEqual(0, warehouse.StockTotal);
    }
}