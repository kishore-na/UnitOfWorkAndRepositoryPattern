﻿using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace LearningDesignPattern.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
