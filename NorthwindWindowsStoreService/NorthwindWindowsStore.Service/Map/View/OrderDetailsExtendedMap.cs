
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class OrderDetailsExtendedMap : BaseMapper<Order_Details_Extended, OrderDetailsExtendedViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Order_Details_Extended, OrderDetailsExtendedViewModel>> GetConfig()
        {
            throw new System.NotImplementedException();
        }
    }
}
