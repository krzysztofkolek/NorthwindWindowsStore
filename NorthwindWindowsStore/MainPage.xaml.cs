using NorthwindWindowsStore.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace NorthwindWindowsStore
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Employees_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EmployeesMain), null);
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CustumersMain), null);
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OrdersMain), null);
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ProductsMain), null);
        }

        private void Shippers_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ShippersMain), null);
        }

        private void Suppliers_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SuppliersMain), null);
        }
    }
}
