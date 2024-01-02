namespace ProductService.Models.DTOs
{
    public class AddProductDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int UnitPrice { get; set; }
        public int UnitsAdded { get; set; }
    }
}
