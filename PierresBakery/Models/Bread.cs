using System.Collections.Generic;

namespace PierresBakery.Models
{
    public class Bread
    {
        public int BreadUnitCost { get; set; } = 5;
        public int OrderedQuantity { get; set; }
        public int FinalQuantity { get; set; }
        public int OrderCost { get; set; }

        public Bread(int qty)
        {
            OrderedQuantity = qty;
        }
    }
}