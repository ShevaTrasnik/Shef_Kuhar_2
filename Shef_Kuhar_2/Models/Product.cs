using System;

namespace Shef_Kuhar_2.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Unit { get; set; }
        public float Calories { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Product(string name, string quantity, string unit, DateTime expiryDate, float calories, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            ExpiryDate = expiryDate;
            Calories = calories;
            Price = price;
        }

    }
}
