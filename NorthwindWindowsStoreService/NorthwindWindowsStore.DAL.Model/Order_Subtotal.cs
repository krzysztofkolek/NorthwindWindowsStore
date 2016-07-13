namespace NorthwindWindowsStore.DAL.Model
{
    using NorthwindWindowsStore.DAL.Model.Interface;


    public partial class Order_Subtotal : IOrderSubtotal
    {
        public int OrderID { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
