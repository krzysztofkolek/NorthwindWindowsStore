namespace NorthwindWindowsStore.DAL.Model
{
    using NorthwindWindowsStore.DAL.Model.Interface;


    public partial class Sales_by_Category : ISalesByCategory
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductSales { get; set; }
    }
}
