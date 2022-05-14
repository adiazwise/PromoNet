using PromoNet.src.Business;
using PromoNet.src.Core.Concrete;
using PromoNet.src.Core.interfaces;
using PromoNet.src.Core.Services;

namespace PromoNet.UI
{
    class Program
    {
        static void Main(string[] args)
        {
        


            List<IOrderProcessor> ordersProcessors = 
            new List<IOrderProcessor>(){
                new DefaultOrderProcessor(new MarketARepository()),
                new DefaultOrderProcessor(new MarketBRepository())
            };

           

            var fileProcessor = new FileProcessor(
            lineColumns: $"OrderNumber{(char)ConsoleKey.Tab}Points{(char)ConsoleKey.Tab}FormatCode",
            pathFile:@"C:\Temp\pointFile.txt"
            );
              var promoRaffle = new DefaultPromoRaffle
               (ordersProcessors,
            new DefaultPointGenerator(new PointRulesRepository(),new BinsRepository()),fileProcessor
            );

            promoRaffle.PromoProccesor();


           
        }
    }
}