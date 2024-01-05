﻿namespace CartService.Models.DTOs
{
    public class ResponseDTO
    {
        public string ErrorMessage { get; set; } = string.Empty;

        public object Result { get; set; } = default!;
        public string Status { get; set; } = string.Empty;

        public bool IsSuccess { get; set; } = true;
    }
}
