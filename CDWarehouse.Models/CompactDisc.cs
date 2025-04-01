namespace CDWarehouse.Models;

public class CompactDisc
{
    public int QuantityInStock { get; private set; }
    public string Artist { get; set; }
    public string Title { get; set; }

    public CompactDisc(int quantityInStock, string artist, string title)
    {
        QuantityInStock = quantityInStock;
        Artist = artist;
        Title = title;
    }

    public void Buy(int quantity)
    {
        QuantityInStock = QuantityInStock - quantity;
    }
}