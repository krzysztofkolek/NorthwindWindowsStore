namespace NorthwindWindowsStore.ViewModel
{
    using System.Collections.Generic;

    public partial class TerritoryViewModel
    {
        public TerritoryViewModel()
        {
            Employees = new HashSet<EmployeeViewModel>();
        }
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
        public virtual RegionViewModel Region { get; set; }
        public virtual ICollection<EmployeeViewModel> Employees { get; set; }
    }
}
