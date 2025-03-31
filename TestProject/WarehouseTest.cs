namespace TestProject;

public class WarehouseTest
{
    [Test]
    public void CDIsBoughtAndStockDecrements()
    {
        Warehouse warehouse = new Warehouse(initialAmount: 1);
        warehouse.BuyCD(1);

        Assert.AreEqual(0, warehouse.StockTotal);
    }

    [Test]
    public void MultipleCDsAreBoughtAndStockDecrementsByAmountBought()
    {
        Warehouse warehouse = new Warehouse(initialAmount: 4);
        warehouse.BuyCD(4);

        Assert.AreEqual(0, warehouse.StockTotal);
    }
}