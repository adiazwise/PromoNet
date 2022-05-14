using PromoNet.src.Core.interfaces;
using PromoNet.src.Core.Models;

namespace PromoNet.src.Business
{
    public class DefaultPromoRaffle : IPromotion
    {
        private readonly List<IOrderProcessor> _orderProcessors;
        private readonly IPointGenerator _pointGenerator;
        private readonly IFileProcessor _fileProcessor;

        public DefaultPromoRaffle(List<IOrderProcessor> orderProcessors,
                                IPointGenerator pointGenerator,
                                IFileProcessor fileProcessor)
        {
            _orderProcessors = orderProcessors;
            _pointGenerator = pointGenerator;
            _fileProcessor = fileProcessor;
        }


        public void PromoProccesor()
        {
           List<Point> pointsGenerated = new List<Point>();
           foreach (var currentOrderProcessor in _orderProcessors)
           {
               var orders  = currentOrderProcessor.GetOrders();
               orders.ForEach(o =>{
                  pointsGenerated.Add(new Point{
                      QtyPoints = _pointGenerator.GetPoints(o),
                      FormatCode = o.FormatCode ?? "",
                      OrderNumber = o.Id
                  }); 
               });
           }
           pointsGenerated.ForEach(p=>_fileProcessor.SendFile(p.ToString()));
        }
   
    }
    
}