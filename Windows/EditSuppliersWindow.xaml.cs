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
    /// Логика взаимодействия для EditSuppliersWindow.xaml
    /// </summary>
    public partial class EditSuppliersWindow : Window
    {
        private Supplier _supplier;
        public EditSuppliersWindow(Supplier supplier)
        {
            InitializeComponent();
            _supplier = supplier;
            txttitle.Text = _supplier.SuppliersName;
            txtgoods.Text = _supplier.Goods;

        }

        private void BtnSave_edi_Click(object sender, RoutedEventArgs e)
        {
            {
                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(txttitle.Text) || string.IsNullOrWhiteSpace(txtgoods.Text))
                {
                    MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Обновляем свойства поставщика на основе введенных данных
                _supplier.SuppliersName = txttitle.Text;
                _supplier.Goods = txtgoods.Text;

                MessageBox.Show("Поставщик успешно обновлен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                DialogResult = true; // Указываем, что изменения успешно сохранены
                Close();
            }
        }

                private void Btnback_edi_Click(object sender, RoutedEventArgs e)
                {
                    WindowSupplier window = new WindowSupplier();
                    window.Show();
                    this.Close();
                }
            }
        }
