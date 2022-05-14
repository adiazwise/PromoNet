using PromoNet.src.Core.Models;

namespace PromoNet.src.Core.interfaces
{
    public interface IPointGenerator
    {
        int GetPoints(Order order);
    }
}