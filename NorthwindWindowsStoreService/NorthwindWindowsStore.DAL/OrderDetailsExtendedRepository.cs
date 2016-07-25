namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class OrderDetailsExtendedRepository : BaseView<Order_Details_Extended>
    {
        public OrderDetailsExtendedRepository(string path)
            : base(path)
        {
        }
    }
}
