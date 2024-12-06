using Confectioner.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
	/// Логика взаимодействия для WindowClients.xaml
	/// </summary>
	public partial class WindowClients : Window
	{
		Prd2Context rdContext = new Prd2Context();
		public WindowClients()
		{
			InitializeComponent();
			dtgclient.ItemsSource = rdContext.Clients.ToList();

			cmbclients.ItemsSource = rdContext.Clients.ToList();
			cmbclients.SelectedValuePath = "IdClient";
			cmbclients.DisplayMemberPath = "Address";


		}

		private void Button_ADD_Click(object sender, RoutedEventArgs e)
		{
			WindowAddClients windowAddClients = new WindowAddClients();
			windowAddClients.Show();
			this.Close();
		}


		private void Button_back_Click(object sender, RoutedEventArgs e)
		{
			WindowPrime window = new WindowPrime();
			window.Show();
			this.Close();
		}

		private void Button_delete_Click(object sender, RoutedEventArgs e)
		{
			var clientsForRemoving = dtgclient.SelectedItems.Cast<Client>().ToList();

			try
			{
				if (clientsForRemoving.Count() > 0)
				{
					if (MessageBox.Show($"Удалить {clientsForRemoving.Count()} клиента?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
						rdContext.Clients.RemoveRange(clientsForRemoving);
					rdContext.SaveChanges();
					MessageBox.Show("Данные удалены");
					dtgclient.ItemsSource = rdContext.Clients.ToList();
				}
				else
					MessageBox.Show("Клиенты не указаны", "Внимание", MessageBoxButton.OK,
						MessageBoxImage.Warning);
				}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
		}

		private void Button_update_Click(object sender, RoutedEventArgs e)
		{
			
		}

		private void cmbclients_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int client =int.Parse(cmbclients.SelectedValue.ToString());
			dtgclient.ItemsSource = rdContext.Clients.Where(x=>x.IdClient == client).ToList();
		}

		private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
		{
			string searchText = txtSearch.Text;
			dtgclient.ItemsSource = rdContext.Clients.Where(x => x.Phone.Contains(searchText)).ToList();
		}

	private void dtgclient_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void rdUp_Click(object sender, RoutedEventArgs e)
		{
			dtgclient.ItemsSource = rdContext.Clients.OrderBy(x => x.FirstName).ToList();
		}

		private void rdDown_Click(object sender, RoutedEventArgs e)
		{
			dtgclient.ItemsSource = rdContext.Clients.OrderByDescending(x => x.FirstName).ToList();
		}

		private void BtnEditProduct_two_Click(object sender, RoutedEventArgs e)
		{
			WindowAddClients window = new WindowAddClients();
			window.Show();
			this.Close();
			
		}

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
			using (Prd2Context context = new Prd2Context())
			{ 	
				Button button = sender as Button;
            Client selectedClient = button.DataContext as Client;

				if (selectedClient != null)
				{
					EditClientWindow editWindow = new EditClientWindow(selectedClient);
					if (editWindow.ShowDialog() == true)
					{
						// Обновляем привязку DataGrid, если необходимо
						//dtgclient.Items.Refresh();
						context.Clients.Update(selectedClient);
						context.SaveChanges();
					}
				}
            }
        }
    }
    }
