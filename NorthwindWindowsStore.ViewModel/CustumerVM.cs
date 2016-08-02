namespace NorthwindWindowsStore.ViewModel
{
    using NorthwindWindowsStore.ViewModel.Utils;
    using System.Collections.Generic;

    public class CustumerVM
    {
        private List<CustumerGridVM> _grid { get; set; }
        public List<CustumerGridVM> Grid
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


        public CustumerVM()
        {
            Grid = ContentManager.GetContent<CustomerViewModel, CustumerGridVM>("Customer/GetAll").Result;
        }

    }
}
