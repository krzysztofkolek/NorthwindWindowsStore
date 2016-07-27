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
                    config.Ignore(x => x.Employee1);
                    config.Ignore(x => x.Employees1);
                    config.Ignore(x => x.Orders);
                    config.Ignore(x => x.Territories);
                    config.Bind(x => x.Address, o => o.Address);
                    config.Bind(x => x.BirthDate, o => o.BirthDate);
                    config.Bind(x => x.City, o => o.City);
                    config.Bind(x => x.Country, o => o.Country);
                    config.Bind(x => x.EmployeeID, o => o.EmployeeID);
                    config.Bind(x => x.Extension, o => o.Extension);
                    config.Bind(x => x.FirstName, o => o.FirstName);
                    config.Bind(x => x.HireDate, o => o.HireDate);
                    config.Bind(x => x.HomePhone, o => o.HomePhone);
                    config.Bind(x => x.LastName, o => o.LastName);
                    config.Bind(x => x.Notes, o => o.Notes);
                    config.Bind(x => x.Photo, o => o.Photo);
                    config.Bind(x => x.PhotoPath, o => o.PhotoPath);
                    config.Bind(x => x.PostalCode, o => o.PostalCode);
                    config.Bind(x => x.Region, o => o.Region);
                    config.Bind(x => x.ReportsTo, o => o.ReportsTo);
                    config.Bind(x => x.Title, o => o.Title);
                    config.Bind(x => x.TitleOfCourtesy, o => o.TitleOfCourtesy);
                }
            );
        }
    }
}
