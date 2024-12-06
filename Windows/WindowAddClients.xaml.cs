using Confectioner.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
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
    /// Логика взаимодействия для WindowAddClients.xaml
    /// </summary>
    public partial class WindowAddClients : Window
    {
		
		private Client _currentClient = new Client();
		public WindowAddClients()
        {
            InitializeComponent();
			

		}


		private void Btnback_three_Click(object sender, RoutedEventArgs e)
		{
			WindowClients window = new WindowClients();
			window.Show();
			this.Close();
		}

		private void BtnSave_Click(object sender, RoutedEventArgs e)
		{
			using (Prd2Context context = new Prd2Context())
			{_currentClient.FirstName = txtname.Text;
					_currentClient.Phone = txtphone.Text;
					_currentClient.Address = txtaddress.Text;
				if (_currentClient.IdClient == 0)
				{
					
					context.Clients.Add(_currentClient);

					context.SaveChanges();

					MessageBox.Show("Новый клиент успешно добавлен");
				}
				else
				{
					context.Clients.Update(_currentClient);
				}
			}
			WindowClients window = new WindowClients();
			window.Show();
			this.Close();
		}
	}
}
