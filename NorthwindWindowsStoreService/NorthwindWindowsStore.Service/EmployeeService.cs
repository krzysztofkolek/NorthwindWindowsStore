namespace NorthwindWindowsStore.Service
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class EmployeeService : BaseService<Employee, EmployeeViewModel>
    {
        public EmployeeService(string path)
            : base(path)
        {
        }
    }
}
