namespace NorthwindWindowsStore.DAL.Model
{
    using NorthwindWindowsStore.DAL.Model.Interface;


    public partial class Product_Sales_for_1997 : IProductSalesFor1997
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductSales { get; set; }
    }
}
