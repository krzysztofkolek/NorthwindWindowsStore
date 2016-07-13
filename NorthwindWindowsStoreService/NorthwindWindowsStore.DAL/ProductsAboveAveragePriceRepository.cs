namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class ProductsAboveAveragePriceRepository : BaseRepository<Products_Above_Average_Price>
    {
        public ProductsAboveAveragePriceRepository(string path)
            : base(path)
        {
        }
    }
}
