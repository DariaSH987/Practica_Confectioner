using Confectioner.Windows;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Confectioner
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

        private void txtenumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
            

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string username = txtUsername.Text;
			string password = passwordBox.Password;

			if (ValidateUser(username, password))
			{

				WindowPrime window = new WindowPrime();
				window.Show();
				this.Close();

			}
			else
			{
				MessageBox.Show("Пользователь не найден или введён неверный пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private bool ValidateUser(string username, string password)
		{
			return username == "AnnaCake" && password == "1234";
		}

		private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
		{

        }
    }
}

