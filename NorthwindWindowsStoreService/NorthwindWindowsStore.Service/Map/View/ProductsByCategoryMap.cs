
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class ProductsByCategoryMap : BaseMapper<Products_by_Category, ProductsByCategoryViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Products_by_Category, ProductsByCategoryViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Products_by_Category, ProductsByCategoryViewModel>>(config =>
            {
                config.Bind(x => x.CategoryName, o => o.CategoryName);
                config.Bind(x => x.ProductName, o => o.ProductName);
                config.Bind(x => x.QuantityPerUnit, o => o.QuantityPerUnit);
                config.Bind(x => x.UnitsInStock, o => o.UnitsInStock);
                config.Bind(x => x.Discontinued, o => o.Discontinued);
            });
        }
    }
}
