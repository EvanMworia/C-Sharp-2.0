namespace ProductService.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public int UnitPrice { get; set; }
        public int UnitsPresent { get; set; }
        public bool IsAvailable { get; set; } = false;
    }
}
