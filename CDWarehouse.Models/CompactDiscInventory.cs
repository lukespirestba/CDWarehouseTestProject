namespace CDWarehouse.Models;

public class CompactDiscInventory
{
    public int QuantityInStock { get; private set; }

    public CompactDiscInventory(int quantityInStock)
    {
        QuantityInStock = quantityInStock;
    }

    public void Buy(int quantity, INotifyCharts notifyCharts)
    {
        QuantityInStock = QuantityInStock - quantity;
        notifyCharts.Notify();
    }
}