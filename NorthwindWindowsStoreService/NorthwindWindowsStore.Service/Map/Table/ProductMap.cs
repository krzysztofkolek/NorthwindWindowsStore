namespace NorthwindWindowsStore.Service.Map.Table
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class ProductMap : BaseMapper<Product, ProductViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Product, ProductViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Product, ProductViewModel>>(config =>
            {
                config.Bind(x => x.ProductID, o => o.ProductID);
                config.Bind(x => x.ProductName, o => o.ProductName);
                config.Bind(x => x.SupplierID, o => o.SupplierID);
                config.Bind(x => x.CategoryID, o => o.CategoryID);
                config.Bind(x => x.QuantityPerUnit, o => o.QuantityPerUnit);
                config.Bind(x => x.UnitPrice, o => o.UnitPrice);
                config.Bind(x => x.UnitsInStock, o => o.UnitsInStock);
                config.Bind(x => x.UnitsOnOrder, o => o.UnitsOnOrder);
                config.Bind(x => x.ReorderLevel, o => o.ReorderLevel);
                config.Bind(x => x.Discontinued, o => o.Discontinued);

                config.Ignore(x => x.Category);
                config.Ignore(x => x.Order_Details);
                config.Ignore(x => x.Supplier);
            });
        }
    }
}
