namespace NorthwindWindowsStore.ViewModel
{
    using NorthwindWindowsStore.ViewModel.Utils;
    using System.Collections.Generic;

    public class EmployeeGetPercentInRelationToPositionVM
    {
        private List<EmployeeGetPercentInRelationToPositionDataVM> _grid { get; set; }
        public List<EmployeeGetPercentInRelationToPositionDataVM> Grid
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

        public EmployeeGetPercentInRelationToPositionVM()
        {
            Grid = ContentManager.GetContent<EmployeeGetPercentInRelationToPositionViewModel, EmployeeGetPercentInRelationToPositionDataVM>("Employees/GetPercentInRelationToPosition").Result;
        }
    }
}
