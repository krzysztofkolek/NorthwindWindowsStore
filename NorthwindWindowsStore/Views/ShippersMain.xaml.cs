namespace NorthwindWindowsStore.Views
{
    using NorthwindWindowsStore.Common;
    using NorthwindWindowsStore.ViewModel;
    using System.Collections.Generic;
    using Telerik.UI.Xaml.Controls.Grid;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;

    /// <summary>
    /// Shippers Main page
    /// </summary>
    public sealed partial class ShippersMain : Page
    {
        private List<ShipperVM> _shippers = NorthwindWindowsStore.Utils.ContentManager.GetContent<ShipperViewModel, ShipperVM>("Shippers/GetAll").Result;
        private NavigationHelper navigationHelper;
        private const int MinimumWidthForSupportingTwoPanes = 768;
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        public ShippersMain()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            this.navigationHelper.GoBackCommand = new NorthwindWindowsStore.Common.RelayCommand(() => this.GoBack(), () => this.CanGoBack());

            RadDataGrid grid = this.FindName("ShippersGrid") as RadDataGrid;
            grid.ItemsSource = _shippers;

            this.InvalidateVisualState();
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
