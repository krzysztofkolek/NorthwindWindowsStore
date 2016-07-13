namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class ProductsByCategoryRepository : BaseRepository<Products_by_Category>
    {
        public ProductsByCategoryRepository(string path)
            : base(path)
        {
        }
    }
}
