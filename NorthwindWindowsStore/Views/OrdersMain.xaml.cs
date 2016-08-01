namespace NorthwindWindowsStore.Views
{
    using NorthwindWindowsStore.Common;
    using NorthwindWindowsStore.ViewModel;
    using System.Collections.Generic;
    using System.Linq;
    using Telerik.UI.Xaml.Controls.Grid;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;

    /// <summary>
    /// Orders Main Page
    /// </summary>
    public sealed partial class OrdersMain : Page
    {
        private List<OrderVM> _orders = NorthwindWindowsStore.Utils.ContentManager.GetContent<OrderViewModel, OrderVM>("Orders/GetAll").Result;
        private NavigationHelper navigationHelper;
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        private const int MinimumWidthForSupportingTwoPanes = 768;
        public OrdersMain()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            this.navigationHelper.GoBackCommand = new NorthwindWindowsStore.Common.RelayCommand(() => this.GoBack(), () => this.CanGoBack());

            CheckData();

            RadDataGrid grid = this.FindName("OrdersGrid") as RadDataGrid;
            grid.ItemsSource = _orders;

            this.InvalidateVisualState();
        }

        private void CheckData()
        {
            _orders = (from item in _orders
                       where item != null
                       select item).ToList();
        }

        private bool UsingLogicalPageNavigation()
        {
            return Window.Current.Bounds.Width < MinimumWidthForSupportingTwoPanes;
        }

        private void InvalidateVisualState()
        {
            var visualState = DetermineVisualState();
            VisualStateManager.GoToState(this, visualState, false);
            this.navigationHelper.GoBackCommand.RaiseCanExecuteChanged();
        }

        private string DetermineVisualState()
        {
            if (!UsingLogicalPageNavigation())
                return "PrimaryView";


            var logicalPageBack = false;

            return logicalPageBack ? "SinglePane_Detail" : "SinglePane";
        }

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        private bool CanGoBack()
        {
            return this.navigationHelper.CanGoBack();
        }
        private void GoBack()
        {
            this.navigationHelper.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }
    }
}
