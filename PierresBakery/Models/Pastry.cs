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
    }

}