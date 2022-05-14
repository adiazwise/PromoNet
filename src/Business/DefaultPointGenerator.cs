using PromoNet.src.Core.interfaces;
using PromoNet.src.Core.Models;
using PromoNet.src.Core.Services;

namespace PromoNet.src.Business
{
    public class DefaultPointGenerator : IPointGenerator
    {
        private readonly IPointRepository _pointRepository;
        private readonly BinsRepository _binRepository;

        public DefaultPointGenerator(IPointRepository pointRepository,BinsRepository binrepository)
        {
            _pointRepository = pointRepository;
            _binRepository = binrepository;
        }
        public int GetPoints(Order order)
        {
            var pointRules = _pointRepository.GetRulesByFormat(order.FormatCode??"0");
            int totalPoints = 0;
            if (pointRules == null) return 0;
            if (order.Total >= pointRules.TotalRequired)
            {
                totalPoints += (int) Math.Round(order.Total / pointRules.TotalRequired);

                if (_binRepository.Bins.Any(b=> b.BinNumber == order.BINNumber)){
                    totalPoints +=1;
                }
            }
            return totalPoints;
        }
    }
}