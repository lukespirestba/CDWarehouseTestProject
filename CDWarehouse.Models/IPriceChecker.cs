namespace CDWarehouse.Models
{
    public interface IPriceChecker
    {
        decimal GetLowestPrice(string artist, string title);
    }
}