namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class AlphabeticalListOfProductMap : BaseMapper<Alphabetical_list_of_product, AlphabeticalListOfProductViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Alphabetical_list_of_product, AlphabeticalListOfProductViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Alphabetical_list_of_product, AlphabeticalListOfProductViewModel>>(config =>
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
                config.Bind(x => x.CategoryName, o => o.CategoryName);
            });
        }
    }
}
