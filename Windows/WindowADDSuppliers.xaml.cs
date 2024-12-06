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
using System.Xml.Linq;

namespace Confectioner.Windows
{
	/// <summary>
	/// Логика взаимодействия для WindowADDSuppliers.xaml
	/// </summary>
	public partial class WindowADDSuppliers : Window
	{
		private Supplier _currentSupplier = new Supplier();
		public WindowADDSuppliers()
		{
			InitializeComponent();
		}

		private void BtnSave_two_Click(object sender, RoutedEventArgs e)
		{
			using (Prd2Context context = new Prd2Context())
			{
				_currentSupplier.SuppliersName = txttitle.Text;
				_currentSupplier.Goods = txtgoods.Text;
				if (_currentSupplier.IdSuppliers == 0)
				{

					context.Suppliers.Add(_currentSupplier);

					context.SaveChanges();

					MessageBox.Show("Новый поставщик успешно добавлен");
				}
				else
				{
					context.Suppliers.Update(_currentSupplier);
				}
			}
			WindowSupplier window = new WindowSupplier();
			window.Show();
			this.Close();
		}

		private void Btnback_two_Click(object sender, RoutedEventArgs e)
		{
			WindowSupplier window = new WindowSupplier();
			window.Show();
			this.Close();
        }
    }
}
