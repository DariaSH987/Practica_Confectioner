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

namespace Confectioner.Windows
{
	/// <summary>
	/// Логика взаимодействия для WindowOrder.xaml
	/// </summary>
	public partial class WindowOrder : Window
	{
		Prd2Context rdContext = new Prd2Context();
		public WindowOrder()
		{
			InitializeComponent();

			dtgorder.ItemsSource = rdContext.Orders.Include(x => x.Client).ToList();
			dtgorder.ItemsSource = rdContext.Orders.Include(x => x.Assortment).ToList();

		}

		private void Button_back_tr_Click(object sender, RoutedEventArgs e)
		{
			WindowPrime window = new WindowPrime();
			window.Show();
			this.Close();
		}

		private void Button_ADD_tr_Click(object sender, RoutedEventArgs e)
		{
			WindowAddOrders window = new WindowAddOrders();
			window.Show();
			this.Close();
		}

		private void dtgorder_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}


		private void Button_ADD_tr_Click_1(object sender, RoutedEventArgs e)
		{
			WindowAddOrders window = new WindowAddOrders();
			window.Show();
			this.Close();
		}

		private void rdUp_four_Click(object sender, RoutedEventArgs e)
		{
			dtgorder.ItemsSource = rdContext.Orders.OrderBy(x => x.Price).ToList();
		}

		private void rdDown_four_Click(object sender, RoutedEventArgs e)
		{
			dtgorder.ItemsSource = rdContext.Orders.OrderByDescending(x => x.Price).ToList();
		}

		private void txtSearch_tr_TextChanged(object sender, TextChangedEventArgs e)
		{
			string searchText = txtSearch_tr.Text;
			dtgorder.ItemsSource = rdContext.Orders.Where(x => x.Client.FirstName.Contains(searchText)).ToList();
		}

		private void Button_delete_tre_Click(object sender, RoutedEventArgs e)
		{
			var orderForRemoving = dtgorder.SelectedItems.Cast<Order>().ToList();

			try
			{
				if (orderForRemoving.Count() > 0)
				{
					if (MessageBox.Show($"Удалить {orderForRemoving.Count()} заказ?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
						rdContext.Orders.RemoveRange(orderForRemoving);
					rdContext.SaveChanges();
					MessageBox.Show("Заказ удалён");
					dtgorder.ItemsSource = rdContext.Orders.ToList();
				}
				else
					MessageBox.Show("Такого заказа нет", "Внимание", MessageBoxButton.OK,
						MessageBoxImage.Warning);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
		}

		private void BtnEditProduct_Click(object sender, RoutedEventArgs e)
		{

		}

		private void BtnEditProductor_Click(object sender, RoutedEventArgs e)
		{
			
		
		}
	}
}
	

