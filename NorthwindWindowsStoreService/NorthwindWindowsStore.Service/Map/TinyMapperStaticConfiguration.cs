namespace NorthwindWindowsStore.Service.Map
{
    using Nelibur.ObjectMapper;
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.Service.Map.Table;
    using NorthwindWindowsStore.ViewModel;

    public static class TinyMapperStaticConfiguration
    {
        public static void SetTinyMapperStaticConfiguration()
        {
            TinyMapper.Bind<Employee, EmployeeViewModel>(new EmployeeMap().GetConfig());
            TinyMapper.Bind<Customer, CustomerViewModel>(new CustomerMap().GetConfig());
            TinyMapper.Bind<Order, OrderViewModel>(new OrderMap().GetConfig());
            TinyMapper.Bind<Product, ProductViewModel>(new ProductMap().GetConfig());
            TinyMapper.Bind<Shipper, ShipperViewModel>(new ShipperMap().GetConfig());
            TinyMapper.Bind<Supplier, SupplierViewModel>(new SupplierMap().GetConfig());

            //TinyMapper.Bind<Employee, EmployeeViewModel>(config =>
            //{
            //    config.Ignore(x => x.Employee1);
            //    config.Ignore(x => x.Employees1);
            //    config.Ignore(x => x.Orders);
            //    config.Ignore(x => x.Territories);
            //    config.Bind(x => x.Address, o => o.Address);
            //    config.Bind(x => x.BirthDate, o => o.BirthDate);
            //    config.Bind(x => x.City, o => o.City);
            //    config.Bind(x => x.Country, o => o.Country);
            //    config.Bind(x => x.EmployeeID, o => o.EmployeeID);
            //    config.Bind(x => x.Extension, o => o.Extension);
            //    config.Bind(x => x.FirstName, o => o.FirstName);
            //    config.Bind(x => x.HireDate, o => o.HireDate);
            //    config.Bind(x => x.HomePhone, o => o.HomePhone);
            //    config.Bind(x => x.LastName, o => o.LastName);
            //    config.Bind(x => x.Notes, o => o.Notes);
            //    config.Bind(x => x.Photo, o => o.Photo);
            //    config.Bind(x => x.PhotoPath, o => o.PhotoPath);
            //    config.Bind(x => x.PostalCode, o => o.PostalCode);
            //    config.Bind(x => x.Region, o => o.Region);
            //    config.Bind(x => x.ReportsTo, o => o.ReportsTo);
            //    config.Bind(x => x.Title, o => o.Title);
            //    config.Bind(x => x.TitleOfCourtesy, o => o.TitleOfCourtesy);
            //});
        }
    }
}
