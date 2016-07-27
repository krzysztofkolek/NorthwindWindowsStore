
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class ProductSalesFor1997Map : BaseMapper<Product_Sales_for_1997, ProductSalesFor1997ViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Product_Sales_for_1997, ProductSalesFor1997ViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Product_Sales_for_1997, ProductSalesFor1997ViewModel>>(config =>
            {
                config.Bind(x => x.CategoryName, o => o.CategoryName);
                config.Bind(x => x.ProductName, o => o.ProductName);
                config.Bind(x => x.ProductSales, o => o.ProductSales);
            });
        }
    }
}