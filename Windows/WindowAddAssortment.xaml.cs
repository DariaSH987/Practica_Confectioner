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
  
    public partial class WindowAddAssortment : Window
    {
		private Assortment _currentAssortment = new Assortment();
		public WindowAddAssortment()
        {
            InitializeComponent();
        }

		private void Btnback_four_Click(object sender, RoutedEventArgs e)
		{
            WindowAssortment window = new WindowAssortment();
            window.Show();
            this.Close();
        }

		private void BtnSave_four_Click(object sender, RoutedEventArgs e)
		{
			using (Prd2Context context = new Prd2Context())
			{
				_currentAssortment.ProductName = txtname.Text;
				_currentAssortment.Stuffing = txtstuffing.Text;
				_currentAssortment.Decor = txtdecor.Text;
				_currentAssortment.SupplierId = Convert.ToInt32(txtsupplier.Text);
				_currentAssortment.Price = Convert.ToInt32(txtprice.Text);

				if (_currentAssortment.IdAssortment == 0)
				{

					context.Assortments.Add(_currentAssortment);

					context.SaveChanges();

					MessageBox.Show("Новое изделие успешно добавлен");
				}
				else
				{
					context.Assortments.Update(_currentAssortment);
				}
			}
			WindowAssortment window = new WindowAssortment();
			window.Show();
			this.Close();
		}
    }
}
