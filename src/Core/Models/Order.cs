namespace PromoNet.src.Core.Models
{
    public class Order 
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string? BINNumber {get;set;}
        public string? FormatCode {get;set;}
    }
}