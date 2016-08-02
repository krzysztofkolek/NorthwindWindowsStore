
namespace NorthwindWindowsStore.ViewModel
{
    using NorthwindWindowsStore.ViewModel.Utils;
    using System.Collections.Generic;

    public class ShipperVM
    {
        private List<ShipperGridVM> _grid { get; set; }
        public List<ShipperGridVM> Grid
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

        public ShipperVM()
        {
            Grid = ContentManager.GetContent<ShipperViewModel, ShipperGridVM>("Shippers/GetAll").Result;
        }
    }
}
