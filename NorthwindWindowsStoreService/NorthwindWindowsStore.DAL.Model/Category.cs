namespace NorthwindWindowsStore.DAL.Model
{
    using NorthwindWindowsStore.DAL.Model.Interface;
    using System.Collections.Generic;

    public partial class Category : ICategory
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
