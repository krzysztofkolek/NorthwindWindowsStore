namespace NorthwindWindowsStore.Views
{
    using NorthwindWindowsStore.ViewModel;
    using System.Collections.Generic;
    using Telerik.UI.Xaml.Controls.Grid;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// Suppliers Main pages
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
