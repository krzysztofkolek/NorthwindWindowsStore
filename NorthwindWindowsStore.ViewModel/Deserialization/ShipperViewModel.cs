namespace NorthwindWindowsStore.ViewModel
{
    
    using System.Collections.Generic;


    public partial class ShipperViewModel 
    {
        public ShipperViewModel()
        {
            Orders = new HashSet<OrderViewModel>();
        }
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<OrderViewModel> Orders { get; set; }
    }
}
