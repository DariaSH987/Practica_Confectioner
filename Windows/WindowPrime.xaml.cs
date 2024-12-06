using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Confectioner.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowPrime.xaml
    /// </summary>
    public partial class WindowPrime : Window
    {
        public WindowPrime()
        {
            InitializeComponent();
        }

        private void frnaMain_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void Button_Clients_Click(object sender, RoutedEventArgs e)
        {
            WindowClients window = new WindowClients();
            window.Show();
            this.Close();
        }

        private void Button_Assortment_Click(object sender, RoutedEventArgs e)
        {
            WindowAssortment window = new WindowAssortment();
            window.Show();
            this.Close();
        }

        private void Button_suppliers_Click(object sender, RoutedEventArgs e)
        {
            WindowSupplier window = new WindowSupplier();
            window.Show();
            this.Close();
        }

        private void Button_Orders_Click(object sender, RoutedEventArgs e)
        {
            WindowOrder window = new WindowOrder();
            window.Show();
            this.Close();
        }
    }
}
