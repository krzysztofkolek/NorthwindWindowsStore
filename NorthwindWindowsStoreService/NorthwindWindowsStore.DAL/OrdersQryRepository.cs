namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class OrdersQryRepository : BaseView<Orders_Qry>
    {
        public OrdersQryRepository(string path)
            : base(path)
        {
        }
    }
}
