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
    /// Логика взаимодействия для EditClientWindow.xaml
    /// </summary>

    public partial class EditClientWindow : Window
    {
        private Client _client;
        public EditClientWindow(Client client)
        {
            InitializeComponent();
            _client = client;
            txtname.Text = _client.FirstName;
            txtphone.Text = _client.Phone;
            txtaddress.Text = _client.Address;
        }


        private void Btnback_edit_Click(object sender, RoutedEventArgs e)
        {
            WindowClients window = new WindowClients();
            window.Show();
            this.Close();
        }

        private void BtnSave_edit_Click(object sender, RoutedEventArgs e)
        {
            {
                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtphone.Text))
                {
                    MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Обновляем свойства поставщика на основе введенных данных
                _client.FirstName = txtname.Text;
                _client.Phone = txtphone.Text;
                _client.Address = txtaddress.Text;

                MessageBox.Show("Клиент был успешно обновлен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                DialogResult = true; // Указываем, что изменения успешно сохранены
                Close();

            }
        }
    }
}