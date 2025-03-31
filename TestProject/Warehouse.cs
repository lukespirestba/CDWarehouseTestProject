

namespace TestProject;

internal class Warehouse
{
    public int StockTotal { get; set; } = 1;

    public void BuyCD()
    {
        StockTotal--;
    }

    internal CompactDisc Search(string title, string artist)
    {
        return new CompactDisc(title, artist);
    }
}