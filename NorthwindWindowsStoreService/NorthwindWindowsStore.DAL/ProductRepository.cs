namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(string path)
            : base(path)
        {
        }
    }
}
