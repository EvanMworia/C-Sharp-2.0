namespace CartService.Models
{
    public class CartItem
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
       
        public int ProductPrice { get; set; }
        public int UnitsAdded { get; set; }
    }
}
