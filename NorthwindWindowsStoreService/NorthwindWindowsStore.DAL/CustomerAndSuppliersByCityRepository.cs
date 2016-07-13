namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class CustomerAndSuppliersByCityRepository : BaseRepository<Customer_and_Suppliers_by_City>
    {
        public CustomerAndSuppliersByCityRepository(string path)
            : base(path)
        {
        }
    }
}
