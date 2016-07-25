namespace NorthwindWindowsStore.ViewModel
{



    public partial class OrderDetailViewModel
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public virtual OrderViewModel Order { get; set; }
        public virtual ProductViewModel Product { get; set; }
    }
}
