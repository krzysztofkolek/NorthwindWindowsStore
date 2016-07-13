namespace NorthwindWindowsStore.DAL.Model
{
    using NorthwindWindowsStore.DAL.Model.Interface;
    using System.Collections.Generic;


    public partial class Territory : ITerritory
    {
        public Territory()
        {
            Employees = new HashSet<Employee>();
        }
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
