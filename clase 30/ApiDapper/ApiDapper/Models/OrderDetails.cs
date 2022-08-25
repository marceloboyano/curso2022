namespace ApiDapper.Models
{
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice  { get; set; }
        public int Quantity  { get; set; }
        public bool Discount{ get; set; }
    }
}
