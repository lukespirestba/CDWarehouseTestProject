namespace CDWarehouse.Models;

public interface IChartChecker
{
    bool IsInTop100(ICompactDiscDetails compactDiscDetails);
}