namespace CDWarehouse.Models;

public class CompactDisc
{
    public int QuantityInStock { get; private set; }

    public CompactDisc(int quantityInStock)
    {
        QuantityInStock = quantityInStock;
    }

    public void Buy(int quantity)
    {
        QuantityInStock = QuantityInStock - quantity;
    }
}