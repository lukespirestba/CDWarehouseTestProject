namespace CDWarehouse.Models;

public class CompactDiscInventory
{
    public int QuantityInStock { get; private set; }
    public decimal Price { get; private set; }

    public CompactDiscInventory(int quantityInStock, decimal price)
    {
        QuantityInStock = quantityInStock;
        Price = price;
    }

    public void Buy(int quantity, ICompactDiscDetails cdDetails, IChartChecker chartChecker, IPriceChecker priceChecker, INotifyCharts notifyCharts)
    {
        if (chartChecker.IsInTop100(cdDetails))
        {
            decimal lowestPrice = priceChecker.GetLowestPrice(cdDetails.Artist, cdDetails.Title);
            Price = Math.Min(Price, lowestPrice - 1m);
        }
        QuantityInStock = QuantityInStock - quantity;
        notifyCharts.Notify(cdDetails.Artist, cdDetails.Title, quantity);
    }
}