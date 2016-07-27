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
            #region Tables
            TinyMapper.Bind<Employee, EmployeeViewModel>(new EmployeeMap().GetConfig());
            TinyMapper.Bind<Customer, CustomerViewModel>(new CustomerMap().GetConfig());
            TinyMapper.Bind<Order, OrderViewModel>(new OrderMap().GetConfig());
            TinyMapper.Bind<Product, ProductViewModel>(new ProductMap().GetConfig());
            TinyMapper.Bind<Shipper, ShipperViewModel>(new ShipperMap().GetConfig());
            TinyMapper.Bind<Supplier, SupplierViewModel>(new SupplierMap().GetConfig());
            #endregion Tables

            #region Views
            #endregion Views
        }
    }
}
