using PromoNet.src.Core.interfaces;
using PromoNet.src.Core.Models;

namespace PromoNet.src.Business
{
    public class DefaultOrderProcessor : IOrderProcessor
    {
        private readonly IRepository _repository;
  
        public DefaultOrderProcessor(IRepository repository  )
        {
            _repository = repository;
            
        }
        public List<Order> GetOrders()
        {
            return _repository.GetOrders();
        }
    }
}