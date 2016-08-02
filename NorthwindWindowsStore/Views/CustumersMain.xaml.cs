namespace NorthwindWindowsStore.Views
{
    using NorthwindWindowsStore.Common;
    using NorthwindWindowsStore.ViewModel;
    using Telerik.UI.Xaml.Controls.Grid;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;

    /// <summary>
    /// Custumers Main Page
    /// </summary>
    public sealed partial class CustumersMain : Page
    {
        //private List<CustumerVM> _custumers = NorthwindWindowsStore.Utils.ContentManager.GetContent<CustomerViewModel, CustumerVM>("Customer/GetAll").Result;
        private CustumerVM _custumers { get; set; }
        public CustumerVM Custumers
        {
            get
            {
                if (_custumers == null)
                {
                    _custumers = new CustumerVM();
                }
                return _custumers;
            }
        }

        private NavigationHelper navigationHelper;
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        private const int MinimumWidthForSupportingTwoPanes = 768;

        public CustumersMain()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            this.navigationHelper.GoBackCommand = new NorthwindWindowsStore.Common.RelayCommand(() => this.GoBack(), () => this.CanGoBack());

            RadDataGrid grid = this.FindName("CustumersGrid") as RadDataGrid;
            grid.ItemsSource = Custumers.Grid;

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
