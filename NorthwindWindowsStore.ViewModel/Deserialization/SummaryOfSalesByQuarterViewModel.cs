namespace NorthwindWindowsStore.ViewModel
{
    using System;

    public partial class SummaryOfSalesByQuarterViewModel 
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderID { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
