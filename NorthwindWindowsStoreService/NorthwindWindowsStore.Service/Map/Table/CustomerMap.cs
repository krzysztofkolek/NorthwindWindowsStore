namespace NorthwindWindowsStore.Service.Map.Table
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class CustomerMap : BaseMapper<Customer, CustomerViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Customer, CustomerViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Customer, CustomerViewModel>>(config =>
            {
                config.Bind(x => x.CustomerID, o => o.CustomerID);
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
                config.Ignore(x => x.Orders);
                config.Ignore(x => x.CustomerDemographics);
            });
        }
    }
}
