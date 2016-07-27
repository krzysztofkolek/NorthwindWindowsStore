
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class ProductsByCategoryMap : BaseMapper<Products_by_Category, ProductsByCategoryViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Products_by_Category, ProductsByCategoryViewModel>> GetConfig()
        {
            throw new System.NotImplementedException();
        }
    }
}
