using Flight__n_Bite.Models;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Flight__n_Bite.Views
{
    public sealed partial class FoodsDrinksPage : Page
    {
        public FoodsDrinksPage()
        {
            InitializeComponent();
        }

        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            var element = ((FrameworkElement)sender);
            int id = ((Product)element.DataContext).Id;
            OrderLine orderline = new OrderLine() { Amount = vm.NewAmount, Product = vm.Products.FirstOrDefault(p => p.Id == id) };
            if (orderline != null)
                vm.AddOrderLine(orderline);
        }

        private void DeleteButtonClicked(object sender, RoutedEventArgs e)
        {
            int id = ((OrderLine)((FrameworkElement)sender).DataContext).Id;
            OrderLine orderline = vm.NewOrderLines.FirstOrDefault(ol => ol.Id == id);
            if (orderline != null)
                vm.DeleteOrderLine(orderline.Id);
        }

        private void PlusAmountButton_Click(object sender, RoutedEventArgs e)
        {
            vm.NewAmount += 1;
        }

        private void MinAmountButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(vm.NewAmount - 1 < 1))
                vm.NewAmount -= 1;
        }

        private void NewOrderLineButton_Click(object sender, RoutedEventArgs e)
        {
            vm.NewAmount = 1;
        }

        private void AddOrderButton_Click(object sender, RoutedEventArgs e)
        {
            Order newOrder = new Order() { OrderLines = vm.NewOrderLines.ToList(), Passenger = Shell.Passenger, IsHandled = false };
            vm.AddOrder(newOrder);
        }
    }
}
