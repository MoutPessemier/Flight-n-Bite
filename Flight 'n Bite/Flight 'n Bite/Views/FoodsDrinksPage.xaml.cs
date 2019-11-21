using Flight__n_Bite.Models;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Flight__n_Bite.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FoodsDrinksPage : Page
    {
        public FoodsDrinksPage()
        {
            InitializeComponent();
        }

        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            int id = ((Product)((FrameworkElement)sender).DataContext).Id;
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
    }
}
