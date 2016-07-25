namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class CustomerAndSuppliersByCityRepository : BaseView<Customer_and_Suppliers_by_City>
    {
        public CustomerAndSuppliersByCityRepository(string path)
            : base(path)
        {
        }
    }
}
