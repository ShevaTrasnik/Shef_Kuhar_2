using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shef_Kuhar_2.Models
{
    public class MenuItemModel
    {
        public Recipe Recipe { get; set; }
        public int Portions { get; set; }
        public int Persons { get; set; }
        public MenuItemModel() { }
        public MenuItemModel(Recipe recipe, int portions)
        {
            Recipe = recipe;
            Portions = portions;
        }
    }
}
