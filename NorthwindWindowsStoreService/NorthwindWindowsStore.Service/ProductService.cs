namespace NorthwindWindowsStore.Service
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class ProductService : BaseService<Product, ProductViewModel>
    {
        public ProductService(string path)
            : base(path)
        {
        }
    }
}
