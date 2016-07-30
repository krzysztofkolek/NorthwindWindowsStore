namespace NorthwindWindowsStore.Views
{
    using NorthwindWindowsStore.ViewModel;
    using System.Collections.Generic;
    using Telerik.UI.Xaml.Controls.Grid;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// Shippers Main page
    /// </summary>
    public sealed partial class ShippersMain : Page
    {
        private List<ShipperVM> _shippers = NorthwindWindowsStore.Utils.ContentManager.GetContent<ShipperViewModel, ShipperVM>("Shippers/GetAll").Result;

        public ShippersMain()
        {
            this.InitializeComponent();

            RadDataGrid grid = this.FindName("ShippersGrid") as RadDataGrid;
            grid.ItemsSource = _shippers;
        }
    }
}
