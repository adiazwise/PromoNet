using PromoNet.src.Core.Models;

namespace PromoNet.src.Core.interfaces
{
    public interface IRepository
    {
        List<Order> GetOrders();
    }

    public interface IPointRepository
    {
        PointRules? GetRulesByFormat(string format);
    }
}