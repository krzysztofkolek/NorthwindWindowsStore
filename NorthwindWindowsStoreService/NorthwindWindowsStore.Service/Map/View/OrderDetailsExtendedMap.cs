
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class OrderDetailsExtendedMap : BaseMapper<Order_Details_Extended, OrderDetailsExtendedViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Order_Details_Extended, OrderDetailsExtendedViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Order_Details_Extended, OrderDetailsExtendedViewModel>>(config =>
            {
                config.Bind(x => x.OrderID, o => o.OrderID);
                config.Bind(x => x.ProductID, o => o.ProductID);
                config.Bind(x => x.ProductName, o => o.ProductName);
                config.Bind(x => x.UnitPrice, o => o.UnitPrice);
                config.Bind(x => x.Quantity, o => o.Quantity);
                config.Bind(x => x.Discount, o => o.Discount);
                config.Bind(x => x.ExtendedPrice, o => o.ExtendedPrice);
            });
        }
    }
}
