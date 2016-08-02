namespace NorthwindWindowsStore.ViewModel
{
    using NorthwindWindowsStore.ViewModel.Utils;
    using System.Collections.Generic;

    public class EmployeeVM
    {
        private List<EmployeeDataVM> _grid { get; set; }
        public List<EmployeeDataVM> Grid
        {
            get
            {
                return _grid;
            }

            set
            {
                _grid = value;
            }
        }

        public EmployeeVM()
        {
            Grid = ContentManager.GetContent<EmployeeViewModel, EmployeeDataVM>("Employees/GetAll").Result;
        }
    }
}
