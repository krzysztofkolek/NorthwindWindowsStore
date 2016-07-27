
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class OrdersQryMap : BaseMapper<Orders_Qry, OrdersQryViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Orders_Qry, OrdersQryViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Orders_Qry, OrdersQryViewModel>>(config =>
            {
                config.Bind(x => x.OrderID, o => o.OrderID);
                config.Bind(x => x.CustomerID, o => o.CustomerID);
                config.Bind(x => x.EmployeeID, o => o.EmployeeID);
                config.Bind(x => x.OrderDate, o => o.OrderDate);
                config.Bind(x => x.RequiredDate, o => o.RequiredDate);
                config.Bind(x => x.ShippedDate, o => o.ShippedDate);
                config.Bind(x => x.ShipVia, o => o.ShipVia);
                config.Bind(x => x.Freight, o => o.Freight);
                config.Bind(x => x.ShipName, o => o.ShipName);
                config.Bind(x => x.ShipAddress, o => o.ShipAddress);
                config.Bind(x => x.ShipCity, o => o.ShipCity);
                config.Bind(x => x.ShipRegion, o => o.ShipRegion);
                config.Bind(x => x.ShipPostalCode, o => o.ShipPostalCode);
                config.Bind(x => x.ShipCountry, o => o.ShipCountry);
                config.Bind(x => x.CompanyName, o => o.CompanyName);
                config.Bind(x => x.Address, o => o.Address);
                config.Bind(x => x.City, o => o.City);
                config.Bind(x => x.Region, o => o.Region);
                config.Bind(x => x.PostalCode, o => o.PostalCode);
                config.Bind(x => x.Country, o => o.Country);
            });
        }
    }
}
