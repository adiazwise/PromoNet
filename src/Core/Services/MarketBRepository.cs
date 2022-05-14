using PromoNet.src.Core.interfaces;
using PromoNet.src.Core.Models;

namespace PromoNet.src.Core.Services
{
    public class MarketBRepository : IRepository
    {
        public List<Order> GetOrders()
        {
           return new List<Order>
           {
             new Order(){Id = 1,Total = 1600,BINNumber = "455599",FormatCode="298"},
             new Order(){Id = 2,Total = 1500,BINNumber = "455599",FormatCode="298"},
           };
        }
    }
}