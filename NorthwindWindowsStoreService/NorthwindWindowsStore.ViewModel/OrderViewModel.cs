namespace NorthwindWindowsStore.ViewModel
{

    using System;
    using System.Collections.Generic;

    public partial class OrderViewModel
    {
        public OrderViewModel()
        {
            Order_Details = new HashSet<OrderDetailViewModel>();
        }
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public virtual CustomerViewModel Customer { get; set; }
        public virtual EmployeeViewModel Employee { get; set; }
        public virtual ICollection<OrderDetailViewModel> Order_Details { get; set; }
        public virtual ShipperViewModel Shipper { get; set; }
    }
}
