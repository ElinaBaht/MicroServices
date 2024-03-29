﻿namespace Services.ProductAPI.DBContext.Models.Dto
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object? Result { get; set; }
        public string? DisplayMessages { get; set; }
        public List<string>? ErrorMessages { get; set; }
    }
}
