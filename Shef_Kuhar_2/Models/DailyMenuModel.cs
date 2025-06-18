using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shef_Kuhar_2.Models
{
    public class DailyMenuModel
    {
        public DateTime Date { get; set; }
        public int Persons { get; set; }
        public List<MenuItemModel> Items { get; set; }

        public DailyMenuModel()
        {
            Items = new List<MenuItemModel>();
        }
    }
}