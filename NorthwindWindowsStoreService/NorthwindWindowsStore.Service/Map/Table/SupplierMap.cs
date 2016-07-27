namespace NorthwindWindowsStore.Service.Map.Table
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class SupplierMap : BaseMapper<Supplier, SupplierViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Supplier, SupplierViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Supplier, SupplierViewModel>>(config =>
            {
                config.Bind(x => x.SupplierID, o => o.SupplierID);
                config.Bind(x => x.CompanyName, o => o.CompanyName);
                config.Bind(x => x.ContactName, o => o.ContactName);
                config.Bind(x => x.ContactTitle, o => o.ContactTitle);
                config.Bind(x => x.Address, o => o.Address);
                config.Bind(x => x.City, o => o.City);
                config.Bind(x => x.Region, o => o.Region);
                config.Bind(x => x.PostalCode, o => o.PostalCode);
                config.Bind(x => x.Country, o => o.Country);
                config.Bind(x => x.Phone, o => o.Phone);
                config.Bind(x => x.Fax, o => o.Fax);
                config.Bind(x => x.HomePage, o => o.HomePage);

                config.Ignore(x => x.Products);
            });
        }
    }
}
