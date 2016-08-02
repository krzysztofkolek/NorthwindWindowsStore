namespace NorthwindWindowsStore.ViewModel
{
    using NorthwindWindowsStore.ViewModel.Utils;
    using System.Collections.Generic;

    public class SupplierVM : BaseVM<SupplierViewModel>
    {
        private List<SupplierGridVM> _grid { get; set; }
        public List<SupplierGridVM> Grid
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

        public SupplierVM()
        {
            Grid = ContentManager.GetContent<SupplierViewModel, SupplierGridVM>("Suppliers/GetAll").Result;
        }
    }
}
