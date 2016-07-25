namespace NorthwindWindowsStore.ViewModel
{
    using System;
    using System.Collections.Generic;

    public partial class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            Employees1 = new HashSet<EmployeeViewModel>();
            Orders = new HashSet<OrderViewModel>();
            Territories = new HashSet<TerritoryViewModel>();
        }
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        public virtual ICollection<EmployeeViewModel> Employees1 { get; set; }
        public virtual EmployeeViewModel Employee1 { get; set; }
        public virtual ICollection<OrderViewModel> Orders { get; set; }
        public virtual ICollection<TerritoryViewModel> Territories { get; set; }
    }
}