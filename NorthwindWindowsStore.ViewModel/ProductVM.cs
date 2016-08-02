
namespace NorthwindWindowsStore.ViewModel
{
    using NorthwindWindowsStore.ViewModel.Utils;
    using System.Collections.Generic;

    public class ProductVM
    {
        private List<ProductGridVM> _grid { get; set; }
        public List<ProductGridVM> Grid
        {
            get
            {
                return _grid;
            }

            set
            {
                _grid = value;
            }
        }

        public ProductVM()
        {
            Grid = ContentManager.GetContent<ProductViewModel, ProductGridVM>("Products/GetAll").Result;
        }
    }
}
