using CDWarehouse.Models;

namespace TestProject;

public class CompactDiscTest
{
    [Test]
    public void CDIsBoughtAndStockDecrements()
    {
        CompactDisc cd = new CompactDisc(1, "Artist", "Title");
        cd.Buy(1);

        Assert.That(cd.QuantityInStock, Is.EqualTo(0));
    }
}