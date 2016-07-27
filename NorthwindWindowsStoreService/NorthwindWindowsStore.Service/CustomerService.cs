namespace NorthwindWindowsStore.Service
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class CustomerService : BaseService<Customer, CustomerViewModel>
    {
        public CustomerService(string path)
            : base(path)
        {
        }
    }
}
