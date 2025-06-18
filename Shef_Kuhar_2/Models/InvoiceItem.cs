using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shef_Kuhar_2.Models
{
    public class InvoiceItem
    {
        public string ProductName { get; set; }
        public float NeededAmount { get; set; }
        public float AvailableAmount { get; set; }
        public float Shortage { get; set; }
        public string Unit { get; set; }
    }
}
