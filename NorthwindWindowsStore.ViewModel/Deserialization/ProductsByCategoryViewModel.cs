namespace NorthwindWindowsStore.ViewModel
{
    
    using System;
    using System.Collections.Generic;


    public partial class ProductsByCategoryViewModel 
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
