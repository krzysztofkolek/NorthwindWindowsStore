namespace NorthwindWindowsStore.Service
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class OrderService : BaseService<Order, OrderViewModel>
    {
        public OrderService(string path)
            : base(path)
        {
        }
    }
}
