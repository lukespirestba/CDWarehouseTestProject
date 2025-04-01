using CDWarehouse.Models;
using Moq;

namespace TestProject;

public class CompactDiscTest
{
    [Test]
    public void CDIsBoughtAndStockDecrements()
    {
        CompactDiscInventory cd = new CompactDiscInventory(1, 0m);
        ICompactDiscDetails cdDetails = new CompactDiscDetailsStub();

        cd.Buy(1, cdDetails, new Mock<IChartChecker>().Object, new Mock<IPriceChecker>().Object, new Mock<INotifyCharts>().Object);

        Assert.That(cd.QuantityInStock, Is.EqualTo(0));
    }

    [Test]
    public void NotifyWhenCDIsBought()
    {
        Mock<INotifyCharts> notifier = new();

        CompactDiscInventory cd = new CompactDiscInventory(1, 0m);
        ICompactDiscDetails cdDetails = new CompactDiscDetailsStub();

        int quantityToBuy = 1;

        cd.Buy(quantityToBuy, cdDetails, new Mock<IChartChecker>().Object, new Mock<IPriceChecker>().Object, notifier.Object);

        notifier.Verify(notifier => notifier.Notify(cdDetails.Artist, cdDetails.Title, quantityToBuy), Times.Once);
    }

    [TestCase(9.99, 9.99)]
    [TestCase(9.99, 8.99)]
    [TestCase(9.99, 10.99)]
    [TestCase(9, 9.5)]    
    public void UpdatePriceIfCDBoughtIsInTop100(decimal currentStockPrice, decimal competitivePrice)
    {
        decimal expectedReducedPrice = competitivePrice - 1m;

        Mock<INotifyCharts> notifier = new();

        CompactDiscInventory cdInventory = new CompactDiscInventory(1, currentStockPrice);

        Mock<IChartChecker> chartChecker = new();
        chartChecker.Setup(cc => cc.IsInTop100(It.IsAny<ICompactDiscDetails>())).Returns(true);

        Mock<IPriceChecker> priceChecker = new();
        priceChecker.Setup(pc => pc.GetLowestPrice(It.IsAny<string>(), It.IsAny<string>())).Returns(competitivePrice);

        ICompactDiscDetails cdDetails = new CompactDiscDetailsStub();

        cdInventory.Buy(1, cdDetails, chartChecker.Object, priceChecker.Object, notifier.Object);

        Assert.That(cdInventory.Price, Is.EqualTo(expectedReducedPrice));
    }
}

public class CompactDiscDetailsStub : ICompactDiscDetails
{
    public string Artist => "Artist";

    public string Title => "Title";
}