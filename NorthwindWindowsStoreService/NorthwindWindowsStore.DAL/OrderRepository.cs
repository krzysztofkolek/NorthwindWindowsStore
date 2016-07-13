namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(string path)
            : base(path)
        {
        }
    }
}
