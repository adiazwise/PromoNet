using PromoNet.src.Core.interfaces;
using PromoNet.src.Core.Models;

namespace PromoNet.src.Core.Services
{
    public class MarketARepository : IRepository
    {
        public List<Order> GetOrders()
        {
             return new List<Order>
           {
             new Order(){Id = 3,Total = 800,BINNumber = "455599",FormatCode="898"},
             new Order(){Id = 4,Total = 500,BINNumber = "455599",FormatCode ="898"},
           };
        }
    }
}