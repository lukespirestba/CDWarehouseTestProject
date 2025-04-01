namespace CDWarehouse.Models;
public interface INotifyCharts
{
    void Notify(string artist, string title, int quantityToBuy);
}
