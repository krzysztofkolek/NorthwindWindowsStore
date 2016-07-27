
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class CurrentProductListMap : BaseMapper<Current_Product_List, CurrentProductListViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Current_Product_List, CurrentProductListViewModel>> GetConfig()
        {
            throw new System.NotImplementedException();
        }
    }
}
