using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shef_Kuhar_2.Models
{
    public class RecipeIngredient
    {
        public string ProductName { get; set; }
        public double Quantity { get; set; } 
        public double CaloriesPer100g { get; set; }
        public double GetCalories()
        {
            return (CaloriesPer100g * Quantity) / 100;
        }
    }

}
