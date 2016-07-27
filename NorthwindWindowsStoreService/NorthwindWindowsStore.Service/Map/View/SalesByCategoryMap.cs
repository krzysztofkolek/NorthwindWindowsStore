
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class SalesByCategoryMap : BaseMapper<Sales_by_Category, SalesByCategoryViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Sales_by_Category, SalesByCategoryViewModel>> GetConfig()
        {
            throw new System.NotImplementedException();
        }
    }
}
