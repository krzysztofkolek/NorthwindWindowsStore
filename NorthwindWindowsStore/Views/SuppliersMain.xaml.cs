using NorthwindWindowsStore.ViewModel;
using System.Collections.Generic;
using Telerik.UI.Xaml.Controls.Grid;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace NorthwindWindowsStore.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SuppliersMain : Page
    {
        private List<SupplierVM> _suppliers = NorthwindWindowsStore.Utils.ContentManager.GetContent<SupplierViewModel, SupplierVM>("Suppliers/GetAll").Result;

        public SuppliersMain()
        {
            this.InitializeComponent();

            RadDataGrid grid = this.FindName("SuppliersGrid") as RadDataGrid;
            grid.ItemsSource = _suppliers;
        }
    }
}
