
namespace NorthwindWindowsStore.ViewModel
{
    using NorthwindWindowsStore.ViewModel.Utils;
    using System.Collections.Generic;

    public class OrderVM
    {
        private List<OrderGridVM> _grid { get; set; }
        public List<OrderGridVM> Grid
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

        public OrderVM()
        {
            Grid = ContentManager.GetContent<OrderViewModel, OrderGridVM>("Order/GetAll").Result;
        }
    }
}
