using System;

namespace PierresBakery.Models
{

    public class Pastry : Bread
    {
        public int PastryUnitCost { get; set; } = 2;
        public int PastryCostForThree { get; set; } = 5;

        public Pastry(int qty) : base(qty)
        {
            OrderedQuantity = qty;
        }

        public static long UnixTimeNow()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }
        public override int FindTotalCost()  //inherited "virtual" method
        {
            int multipleOfThree = (int)OrderedQuantity / 3;
            OrderCost = (multipleOfThree * PastryCostForThree) + ((OrderedQuantity % 3) * PastryUnitCost);
            return OrderCost;
        }
    }

}