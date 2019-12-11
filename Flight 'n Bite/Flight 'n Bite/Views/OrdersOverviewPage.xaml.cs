using Flight__n_Bite.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Flight__n_Bite.Views
{
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

        private void DeclineButton_Click(object sender, RoutedEventArgs e)
        {
            var order = ((Order)((FrameworkElement)sender).DataContext);
            vm.DeleteOrder(order);
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            var order = ((Order)((FrameworkElement)sender).DataContext);
            vm.HandleOrder(order);
        }
    }
}
