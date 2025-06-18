using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shef_Kuhar_2.Models
{
        public class Recipe
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public double OutputGrams { get; set; }
            public string Instructions { get; set; }
            public List<RecipeIngredient> Ingredients { get; set; }
            public override string ToString()
            {
                return $"{Name} ({Category})";
            }
    }

}
