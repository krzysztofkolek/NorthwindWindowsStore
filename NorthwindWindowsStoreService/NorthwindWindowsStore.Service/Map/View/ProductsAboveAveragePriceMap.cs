
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class ProductsAboveAveragePriceMap : BaseMapper<Products_Above_Average_Price, ProductsAboveAveragePriceViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Products_Above_Average_Price, ProductsAboveAveragePriceViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Products_Above_Average_Price, ProductsAboveAveragePriceViewModel>>(config =>
            {
                config.Bind(x => x.ProductName, o => o.ProductName);
                config.Bind(x => x.UnitPrice, o => o.UnitPrice);
            });
        }
    }
}
