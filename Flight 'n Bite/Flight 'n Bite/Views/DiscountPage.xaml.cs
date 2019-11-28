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
    public sealed partial class DiscountPage : Page
    {
        public DiscountPage()
        {
            this.InitializeComponent();
        }

        private void PlusDiscountButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(vm.Discount + 5 > 100))
                vm.Discount += 5;
        }

        private void MinDiscountButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(vm.Discount - 5 < 0))
                vm.Discount -= 5;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            vm.UpdateDiscount();
        }

        private void ChangeProductButton_Click(object sender, RoutedEventArgs e)
        {
            int id = ((Product)((FrameworkElement)sender).DataContext).Id;
            Product product = vm.Products.FirstOrDefault(p => p.Id == id);
            vm.currentProduct = product;
            vm.Discount = product.Discount;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            int id = ((Product)((FrameworkElement)sender).DataContext).Id;
            Product product = vm.Products.FirstOrDefault(p => p.Id == id);
            vm.currentProduct = product;
            vm.Discount = 0;
            vm.UpdateDiscount();
        }
    }
}
