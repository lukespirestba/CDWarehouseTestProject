using CDWarehouse.Models;
using Moq;
using System.Collections.Specialized;

namespace TestProject;

public class CompactDiscTest
{
    [Test]
    public void CDIsBoughtAndStockDecrements()
    {
        CompactDiscInventory cd = new CompactDiscInventory(1);
        cd.Buy(1, new Mock<INotifyCharts>().Object);

        Assert.That(cd.QuantityInStock, Is.EqualTo(0));
    }

    [Test]
    public void NotifyWhenCDIsBought()
    {
        Mock<INotifyCharts> notifier = new();
        CompactDiscInventory cd = new CompactDiscInventory(1);

        cd.Buy(1, notifier.Object);

        notifier.Verify(notifier => notifier.Notify(), Times.Once);
    }
}