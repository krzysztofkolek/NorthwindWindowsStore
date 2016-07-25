namespace NorthwindWindowsStore.DAL.Model
{
    using NorthwindWindowsStore.DAL.Model.Interface;

    public partial class Category_Sales_for_1997 : ICategorySalesFor1997, IView
    {
        public string CategoryName { get; set; }
        public decimal? CategorySales { get; set; }
    }
}
