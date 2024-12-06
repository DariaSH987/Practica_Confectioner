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
    /// Логика взаимодействия для EditAssortmentWindow.xaml
    /// </summary>
    public partial class EditAssortmentWindow : Window
    {
        private Assortment _assortment;
        public EditAssortmentWindow(Assortment assortment)
        {
            InitializeComponent();
            _assortment = assortment;

            txtname.Text = _assortment.ProductName;
            txtstuffing.Text = _assortment.Stuffing;
            txtdecor.Text = _assortment.Decor;
            txtsupplier.Text = _assortment.SupplierId.ToString();
            txtprice.Text = _assortment.Price.ToString();
        }
    

        private void BtnSave_ed_Click(object sender, RoutedEventArgs e)
        {
            _assortment.ProductName = txtname.Text;
            _assortment.Stuffing = txtstuffing.Text;
            _assortment.Decor = txtdecor.Text;
            _assortment.Supplier.SuppliersName = txtsupplier.Text;
            if (int.TryParse(txtprice.Text, out int price))
            {
                _assortment.Price = price;
            }
            MessageBox.Show("Изделие было успешно обновлено");


            DialogResult = true; // Указывает, что окно было закрыто с успешным результатом
            Close();
        }

        private void Btnback_ed_Click(object sender, RoutedEventArgs e)
        {
        WindowAddAssortment window = new WindowAddAssortment();
        window.Show();
        this.Close();
        }
    }
}

