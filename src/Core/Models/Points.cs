namespace PromoNet.src.Core.Models
{
    public class Point
    {
        public int OrderNumber { get; set; }
        public int QtyPoints { get; set; }
        public string? FormatCode {get;set;}
        public override string ToString()
        {
            return $"{this.OrderNumber}{(char)ConsoleKey.Tab}{this.QtyPoints}{(char)ConsoleKey.Tab}{this.FormatCode}";
        }
    }
  
}