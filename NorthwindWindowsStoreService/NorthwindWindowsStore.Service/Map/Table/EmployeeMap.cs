namespace NorthwindWindowsStore.Service.Map.Table
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class EmployeeMap : BaseMapper<Employee, EmployeeViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Employee, EmployeeViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Employee, EmployeeViewModel>>(config =>
                {
                    config.Bind(x => x.Address, o => o.Address);
                    config.Bind(x => x.BirthDate, o => o.Address);
                    config.Bind(x => x.City, o => o.Address);
                    config.Bind(x => x.Country, o => o.Address);
                    config.Bind(x => x.Employee1, o => o.Address);
                    config.Bind(x => x.EmployeeID, o => o.Address);
                    config.Bind(x => x.Employees1, o => o.Address);
                    config.Bind(x => x.Extension, o => o.Address);
                    config.Bind(x => x.FirstName, o => o.Address);
                    config.Bind(x => x.HireDate, o => o.Address);
                    config.Bind(x => x.HomePhone, o => o.Address);
                    config.Bind(x => x.LastName, o => o.Address);
                    config.Bind(x => x.Notes, o => o.Address);
                    config.Bind(x => x.Orders, o => o.Address);
                    config.Bind(x => x.Photo, o => o.Address);
                    config.Bind(x => x.PhotoPath, o => o.Address);
                    config.Bind(x => x.PostalCode, o => o.Address);
                    config.Bind(x => x.Region, o => o.Address);
                    config.Bind(x => x.ReportsTo, o => o.Address);
                    config.Bind(x => x.Territories, o => o.Address);
                    config.Bind(x => x.Title, o => o.Address);
                    config.Bind(x => x.TitleOfCourtesy, o => o.Address);
                }
            );
        }
    }
}
