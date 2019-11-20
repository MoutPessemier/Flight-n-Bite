using Flight__n_Bite.Models;
using Flight__n_Bite.ViewModels;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Flight__n_Bite.Views.UserControls
{
    public sealed partial class OrderLineListviewUserControl : UserControl
    {
        public OrderLineListviewUserControl()
        {
            this.InitializeComponent();
        }

        private void DeleteButtonClicked(object sender, RoutedEventArgs e)
        {
            ProductViewModel vm = (ProductViewModel)this.DataContext;
            OrderLine ol = vm.NewOrderLines.FirstOrDefault(ol => ol.Id.Equals(id.Text));
            if (ol != null)
                vm.DeleteOrderLine(ol);
        }
    }
}
