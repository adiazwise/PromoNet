using  PromoNet.src.Core.Models;

namespace PromoNet.src.Core.Services
{
    public class BinsRepository
    {
        public List<Bin> Bins 
        {
            get => new List<Bin>{new Bin(){BinNumber="455599"}};
        }
    }
}