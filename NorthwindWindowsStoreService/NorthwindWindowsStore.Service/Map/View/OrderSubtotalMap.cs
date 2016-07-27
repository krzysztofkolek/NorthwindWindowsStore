
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class OrderSubtotalMap : BaseMapper<Order_Subtotal, OrderSubtotalViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Order_Subtotal, OrderSubtotalViewModel>> GetConfig()
        {
            throw new System.NotImplementedException();
        }
    }
}
