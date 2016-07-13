namespace NorthwindWindowsStore.ViewModel
{

    
    using System.Collections.Generic;


    public partial class RegionViewModel 
    {
        public RegionViewModel()
        {
            Territories = new HashSet<TerritoryViewModel>();
        }
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        public virtual ICollection<TerritoryViewModel> Territories { get; set; }
    }
}
