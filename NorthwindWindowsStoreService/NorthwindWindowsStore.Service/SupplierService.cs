namespace NorthwindWindowsStore.Service
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class SupplierService : BaseService<Supplier, SupplierViewModel>
    {
        public SupplierService(string path)
            : base(path)
        {
        }
    }
}
