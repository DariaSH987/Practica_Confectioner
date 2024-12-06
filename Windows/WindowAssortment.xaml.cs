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
    /// Логика взаимодействия для WindowAssortment.xaml
    /// </summary>
    public partial class WindowAssortment : Window
    {
		Prd2Context rdContext = new Prd2Context();
		public WindowAssortment()
        {
            InitializeComponent();
			dtgassortiment.ItemsSource = rdContext.Assortments.Include(x=>x.Supplier).ToList();

			cmbassortment.ItemsSource = rdContext.Assortments.ToList();
			cmbassortment.SelectedValuePath = "IdAssortment";
			cmbassortment.DisplayMemberPath = "ProductName";
		}

		private void dtgassortiment_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

        }

		private void Button_ADD_four_Click(object sender, RoutedEventArgs e)
		{
            WindowAddAssortment window = new WindowAddAssortment();
            window.Show();
            this.Close();
        }

		private void Button_delete_four_Click(object sender, RoutedEventArgs e)
		{
			var assortmentForRemoving = dtgassortiment.SelectedItems.Cast<Assortment>().ToList();

			try
			{
				if (assortmentForRemoving.Count() > 0)
				{
					if (MessageBox.Show($"Удалить {assortmentForRemoving.Count()} изделие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
						rdContext.Assortments.RemoveRange(assortmentForRemoving);
					rdContext.SaveChanges();
					MessageBox.Show("Данные удалены");
					dtgassortiment.ItemsSource = rdContext.Assortments.ToList();
				}
				else
					MessageBox.Show("Изделия не указаны", "Внимание", MessageBoxButton.OK,
						MessageBoxImage.Warning);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
		}


		private void Button_update_four_Click(object sender, RoutedEventArgs e)
		{

        }

		private void Button_back_four_Click(object sender, RoutedEventArgs e)
		{
            WindowPrime window = new WindowPrime();
            window.Show();
            this.Close();
        }

		private void cmbassortment_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int assortment = int.Parse(cmbassortment.SelectedValue.ToString());
			dtgassortiment.ItemsSource = rdContext.Assortments.Where(x => x.IdAssortment == assortment).ToList();
		}

		private void txtSearch_four_TextChanged(object sender, TextChangedEventArgs e)
		{
            string searchText = txtSearch_four.Text;
            dtgassortiment.ItemsSource = rdContext.Assortments.Where(x => x.Decor.Contains(searchText)).ToList();

        }

		private void rdUp_two_Click(object sender, RoutedEventArgs e)
		{
			dtgassortiment.ItemsSource = rdContext.Assortments.OrderBy(x => x.Stuffing).ToList();
		}

		private void rdDown_two_Click(object sender, RoutedEventArgs e)
		{
			dtgassortiment.ItemsSource = rdContext.Assortments.OrderByDescending(x => x.Stuffing).ToList();
		}

		private void BtnEditProduct_four_Click(object sender, RoutedEventArgs e)
		{
            Button button = sender as Button;
            Assortment selectedAssortment = button.DataContext as Assortment;

            if (selectedAssortment != null)
            {
                EditAssortmentWindow editWindow = new EditAssortmentWindow(selectedAssortment);
                if (editWindow.ShowDialog() == true)
                {
                    dtgassortiment.Items.Refresh(); // Обновляем DataGrid
                }
            }
        }
    }
    }
