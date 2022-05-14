using PromoNet.src.Core.interfaces;
using PromoNet.src.Core.Models;

namespace PromoNet.src.Core.Services
{
    public class PointRulesRepository : IPointRepository
    {
        private readonly List<PointRules> _pointRules;

        public PointRulesRepository()
        {
            _pointRules  = new List<PointRules>
             {
                new PointRules(){ FormatName = "898",TotalRequired = 800.00m},
                new PointRules(){ FormatName = "298",TotalRequired = 1500.00m}
             };

        }
        public PointRules? GetRulesByFormat(string format) 
        {
            if(format == null) return null;
            return _pointRules.FirstOrDefault(p=> p.FormatName == format);
        }
       
            
        
    }
}