namespace NorthwindWindowsStore.ViewModel
{

    using System.Collections.Generic;

    public partial class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Products = new HashSet<ProductViewModel>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<ProductViewModel> Products { get; set; }
    }
}
