namespace NorthwindWindowsStore.Service
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;
    using System.Collections.Generic;
    using System.Linq;

    public class EmployeeService : BaseService<Employee, EmployeeViewModel>
    {
        public EmployeeService(string path)
            : base(path)
        {
        }

        public List<EmployeeGetPercentInRelationToPositionViewModel> GetPercentInRelationToPosition()
        {
            var data = from item in GetAll()
                       group item by item.Title;

            Dictionary<string, double> result = new Dictionary<string, double>();
            int totalSumOfEmployees = 0;
            foreach (var item in data)
            {
                int employeesInGroup = item.ToList().Count;
                totalSumOfEmployees += employeesInGroup;

                result.Add(item.Key, employeesInGroup);
            }

            List<EmployeeGetPercentInRelationToPositionViewModel> endResult = new List<EmployeeGetPercentInRelationToPositionViewModel>();
            foreach (var item in result)
            {
                endResult.Add(new EmployeeGetPercentInRelationToPositionViewModel
                {
                    Title = item.Key,
                    Amount = (item.Value * 100) / totalSumOfEmployees
                });
            }
            return endResult;
        }
    }
}
