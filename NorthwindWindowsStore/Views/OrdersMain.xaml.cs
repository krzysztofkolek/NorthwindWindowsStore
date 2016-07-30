namespace NorthwindWindowsStore.Views
{
    using NorthwindWindowsStore.ViewModel;
    using System.Collections.Generic;
    using System.Linq;
    using Telerik.UI.Xaml.Controls.Grid;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// Orders Main Page
    /// </summary>
    public sealed partial class OrdersMain : Page
    {
        private List<OrderVM> _orders = NorthwindWindowsStore.Utils.ContentManager.GetContent<OrderViewModel, OrderVM>("Orders/GetAll").Result;

        public OrdersMain()
        {
            this.InitializeComponent();
            CheckData();

            RadDataGrid grid = this.FindName("OrdersGrid") as RadDataGrid;
            grid.ItemsSource = _orders;
        }

        private void CheckData()
        {
            _orders = (from item in _orders
                       where item != null
                       select item).ToList();
        }
    }
}
