﻿namespace ProductService.Models.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int UnitPrice { get; set; }
        
    }
}
