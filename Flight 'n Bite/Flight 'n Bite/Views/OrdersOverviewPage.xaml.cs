using Flight__n_Bite.Models;
using System.Linq;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Flight__n_Bite.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrdersOverviewPage : Page
    {
        public OrdersOverviewPage()
        {
            this.InitializeComponent();
        }

        private void OrderList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Order order = (Order)e.ClickedItem;
            if (!order.IsHandled)
            {
                vm.HandleOrder(order);
            }
        }

        private void DeclineButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
