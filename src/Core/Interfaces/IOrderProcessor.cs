using PromoNet.src.Core.Models;

namespace PromoNet.src.Core.interfaces
{
    public interface IOrderProcessor
    {
        List<Order> GetOrders();
    }
}