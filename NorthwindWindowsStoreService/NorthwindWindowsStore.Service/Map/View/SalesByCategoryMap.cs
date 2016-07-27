
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class SalesByCategoryMap : BaseMapper<Sales_by_Category, SalesByCategoryViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Sales_by_Category, SalesByCategoryViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Sales_by_Category, SalesByCategoryViewModel>>(config =>
            {
                config.Bind(x => x.CategoryID, o => o.CategoryID);
                config.Bind(x => x.CategoryName, o => o.CategoryName);
                config.Bind(x => x.ProductName, o => o.ProductName);
                config.Bind(x => x.ProductSales, o => o.ProductSales);
            });
        }
    }
}
