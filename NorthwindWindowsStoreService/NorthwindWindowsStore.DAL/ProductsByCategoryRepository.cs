namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class ProductsByCategoryRepository : BaseView<Products_by_Category>
    {
        public ProductsByCategoryRepository(string path)
            : base(path)
        {
        }
    }
}
