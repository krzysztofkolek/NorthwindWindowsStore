namespace NorthwindWindowsStore.DAL.Model
{
    using NorthwindWindowsStore.DAL.Model.Interface;
    using System;
    using System.Collections.Generic;
    
        
    public partial class Products_by_Category : IProductsByCategory
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
