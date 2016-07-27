namespace NorthwindWindowsStore.ViewModel
{

    using System.Collections.Generic;


    public partial class ProductViewModel
    {
        public ProductViewModel()
        {
            Order_Details = new HashSet<OrderDetailViewModel>();
        }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public string Discontinued { get; set; }
        public virtual CategoryViewModel Category { get; set; }
        public virtual ICollection<OrderDetailViewModel> Order_Details { get; set; }
        public virtual SupplierViewModel Supplier { get; set; }
    }
}
