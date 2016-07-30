namespace NorthwindWindowsStore.Views
{
    using NorthwindWindowsStore.ViewModel;
    using System.Collections.Generic;
    using Telerik.UI.Xaml.Controls.Grid;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductsMain : Page
    {
        private List<ProductVM> _products = NorthwindWindowsStore.Utils.ContentManager.GetContent<ProductViewModel, ProductVM>("Products/GetAll").Result;

        public ProductsMain()
        {
            this.InitializeComponent();

            RadDataGrid grid = this.FindName("ProductsGrid") as RadDataGrid;
            grid.ItemsSource = _products;
        }
    }
}
