using Confectioner.Models;
using Microsoft.EntityFrameworkCore;
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
using System.Xml.Linq;

namespace Confectioner.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowAddOrders.xaml
    /// </summary>
    public partial class WindowAddOrders : Window
    {
		private Order _currentOrder = new Order();
		public WindowAddOrders()
        {
            InitializeComponent();
        }

        private void Button_ADD_tr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_delete_tr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_update_tr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_back_tr_Click(object sender, RoutedEventArgs e)
        {
            
        }


        private void Btnback_th_Click(object sender, RoutedEventArgs e)
        {
            WindowOrder window = new WindowOrder();
            window.Show();
            this.Close();
        }

        private void BtnSave_th_Click(object sender, RoutedEventArgs e)
        {
			using (Prd2Context context = new Prd2Context())
			{
				_currentOrder.Quantity = Convert.ToInt32(txtqua.Text);
				_currentOrder.Price = Convert.ToInt32(txtprice.Text);
				_currentOrder.DateOfIssue = DateOnly.Parse(txtdateof.Text);
				_currentOrder.DataOrder = DateOnly.Parse(txtdateor.Text);
				_currentOrder.ClientId = Convert.ToInt32(txtcl.Text); ;
				_currentOrder.AssortmentId = Convert.ToInt32(txtassort.Text);
				if (_currentOrder.IdOrders == 0)
				{

					context.Orders.Add(_currentOrder);

					context.SaveChanges();

					MessageBox.Show("Новый клиент успешно добавлен");
				}
				else
				{
					context.Orders.Update(_currentOrder);
				}
			}
			WindowOrder window = new WindowOrder();
			window.Show();
			this.Close();
		}
    }
}
