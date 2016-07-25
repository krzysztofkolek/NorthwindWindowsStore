namespace NorthwindWindowsStore.DAL.Model
{

    using NorthwindWindowsStore.DAL.Model.Interface;
    using System.Collections.Generic;


    public partial class Region : IRegion, ITable
    {
        public Region()
        {
            Territories = new HashSet<Territory>();
        }
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
