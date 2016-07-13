namespace NorthwindWindowsStore.ViewModel
{
    
    using System;

    public partial class SalesTotalsByAmountViewModel 
    {
        public decimal? SaleAmount { get; set; }
        public int OrderID { get; set; }
        public string CompanyName { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
