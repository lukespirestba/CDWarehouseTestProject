using CDWarehouse.Models;

namespace TestProject;

public class CompactDiscTest
{
    [Test]
    public void CDIsBoughtAndStockDecrements()
    {
        CompactDisc cd = new CompactDisc(1);
        cd.Buy(1);

        Assert.AreEqual(0, cd.QuantityInStock);
    }
}