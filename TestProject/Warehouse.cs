

namespace TestProject;

internal class Warehouse
{
    public Warehouse(int initialAmount)
    {
        StockTotal = initialAmount;
    }

    public int StockTotal { get; set; }

    public void BuyCD(int amount)
    {
        StockTotal = StockTotal - amount;
    }

    internal CompactDisc Search(string title, string artist)
    {
        return new CompactDisc(title, artist);
    }
}