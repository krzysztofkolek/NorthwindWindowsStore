namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class SalesByCategoryRepository : BaseView<Sales_by_Category>
    {
        public SalesByCategoryRepository(string path)
            : base(path)
        {
        }
    }
}
