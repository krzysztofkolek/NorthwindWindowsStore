
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class OrdersQryMap : BaseMapper<Orders_Qry, OrdersQryViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Orders_Qry, OrdersQryViewModel>> GetConfig()
        {
            throw new System.NotImplementedException();
        }
    }
}
