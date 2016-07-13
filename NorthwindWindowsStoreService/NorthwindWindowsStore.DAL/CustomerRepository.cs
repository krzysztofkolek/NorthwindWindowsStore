namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(string path)
            : base(path)
        {
        }
    }
}
