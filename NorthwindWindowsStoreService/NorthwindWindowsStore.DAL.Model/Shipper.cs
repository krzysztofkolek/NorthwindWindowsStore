namespace NorthwindWindowsStore.DAL.Model
{
    using NorthwindWindowsStore.DAL.Model.Interface;
    using System.Collections.Generic;


    public partial class Shipper : IShipper, ITable
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
