namespace NorthwindWindowsStore.ViewModel
{
    
    using System.Collections.Generic;


    public partial class CustomerDemographicViewModel
    {
        public CustomerDemographicViewModel()
        {
            Customers = new HashSet<CustomerViewModel>();
        }

        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
        public virtual ICollection<CustomerViewModel> Customers { get; set; }
    }
}
