namespace NorthwindWindowsStore.DAL.Model
{
    using NorthwindWindowsStore.DAL.Model.Interface;
    using System.Collections.Generic;


    public partial class Customer : ICustomer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
            CustomerDemographics = new HashSet<CustomerDemographic>();
        }
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CustomerDemographic> CustomerDemographics { get; set; }
    }
}
