
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class OrderSubtotalMap : BaseMapper<Order_Subtotal, OrderSubtotalViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Order_Subtotal, OrderSubtotalViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Order_Subtotal, OrderSubtotalViewModel>>(config =>
            {
                config.Bind(x => x.OrderID, o => o.OrderID);
                config.Bind(x => x.Subtotal, o => o.Subtotal);
            });
        }
    }
}
