using Confectioner.Models;
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
	/// Логика взаимодействия для WindowSupplier.xaml
	/// </summary>
	public partial class WindowSupplier : Window
	{
		Prd2Context rdContext = new Prd2Context();
		public WindowSupplier()
		{
			InitializeComponent();
			dtgsuppliers.ItemsSource = rdContext.Suppliers.ToList();


		}

		private void Button_ADD_two_Click(object sender, RoutedEventArgs e)
		{
			WindowADDSuppliers window = new WindowADDSuppliers();
			window.Show();
			this.Close();
        }

		private void Button_delete_two_Click(object sender, RoutedEventArgs e)
		{
			var suppliersForRemoving = dtgsuppliers.SelectedItems.Cast<Supplier>().ToList();

			try
			{
				if (suppliersForRemoving.Count() > 0)
				{
					if (MessageBox.Show($"Удалить {suppliersForRemoving.Count()} поставщика?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
						rdContext.Suppliers.RemoveRange(suppliersForRemoving);
					rdContext.SaveChanges();
					MessageBox.Show("Данные удалены");
					dtgsuppliers.ItemsSource = rdContext.Suppliers.ToList();
				}
				else
					MessageBox.Show("Поставщики не указаны", "Внимание", MessageBoxButton.OK,
						MessageBoxImage.Warning);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
		}

		private void Button_update_two_Click(object sender, RoutedEventArgs e)
		{

        }

		private void Button_back_two_Click(object sender, RoutedEventArgs e)
		{
			WindowPrime window = new WindowPrime();
			window.Show();
			this.Close();
        }

		private void txtSearch_two_TextChanged(object sender, TextChangedEventArgs e)
		{
            string searchText = txtSearch_two.Text;
            dtgsuppliers.ItemsSource = rdContext.Suppliers.Where(x => x.SuppliersName.Contains(searchText)).ToList();
        }


		private void dtgsuppliers_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void rdUp_one_Click(object sender, RoutedEventArgs e)
		{
			dtgsuppliers.ItemsSource = rdContext.Suppliers.OrderBy(x => x.Goods).ToList();
		}

		private void rdDown_one_Click(object sender, RoutedEventArgs e)
		{
			dtgsuppliers.ItemsSource = rdContext.Suppliers.OrderByDescending(x => x.Goods).ToList();
		}

		private void BtnEditProduct_one_Click(object sender, RoutedEventArgs e)
		{
			using (Prd2Context context = new Prd2Context())
			{
				Button button = sender as Button;
				Supplier selectedSupplier = button.DataContext as Supplier;

				if (selectedSupplier != null)
				{
					EditSuppliersWindow editWindow = new EditSuppliersWindow(selectedSupplier);
					if (editWindow.ShowDialog() == true)
					{
						dtgsuppliers.Items.Refresh(); 
						context.Suppliers.Update(selectedSupplier);
						context.SaveChanges();
					}

				}
			}
        }
    }
}
