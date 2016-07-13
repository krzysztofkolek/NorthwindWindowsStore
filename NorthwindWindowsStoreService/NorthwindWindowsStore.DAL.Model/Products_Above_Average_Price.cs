namespace NorthwindWindowsStore.DAL.Model
{
    using NorthwindWindowsStore.DAL.Model.Interface;


    public partial class Products_Above_Average_Price : IProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
