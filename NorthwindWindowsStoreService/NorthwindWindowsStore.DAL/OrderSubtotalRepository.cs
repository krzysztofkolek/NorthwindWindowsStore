namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class OrderSubtotalRepository : BaseRepository<Order_Subtotal>
    {
        public OrderSubtotalRepository(string path)
            : base(path)
        {
        }
    }
}
