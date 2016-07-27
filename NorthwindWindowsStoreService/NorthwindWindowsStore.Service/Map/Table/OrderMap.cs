namespace NorthwindWindowsStore.Service.Map.Table
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;
    using System;

    public class OrderMap : BaseMapper<Order, OrderViewModel>
    {
        public override Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Order, OrderViewModel>> GetConfig()
        {
            return new Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Order, OrderViewModel>>(config =>
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
            });
        }
    }
}
