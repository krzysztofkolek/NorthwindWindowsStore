namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class OrderDetailRepository : BaseRepository<Order_Detail>
    {
        public OrderDetailRepository(string path)
            : base(path)
        {
        }
    }
}
