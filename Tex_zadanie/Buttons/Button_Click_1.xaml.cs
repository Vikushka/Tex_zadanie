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

namespace Tex_zadanie.Buttons
{
    /// <summary>
    /// Логика взаимодействия для Button_Click_1.xaml
    /// </summary>
    public partial class Button_Click_1 : Window
    {
        private Product Product{get; set;}

        public Button_Click_1(Product product)
        {
            InitializeComponent();
            Product = product;
            DataContext = Product;
            Product = product;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;

            Product product = new Product
            {
                Price = Product.Price,
                Name = Product.Name,
                ID = Guid.NewGuid(),
                Description = Product.Description
            };
            string show = "Уникальный идентификатор: " + Product.ID + "\r\n" + "Имя товара: " + Product.Name + "\r\n" + "Описание товара: " + Product.Description + "\r\n" + "Цена товара: " + Product.Price + " RUB";
            MessageBox.Show(show, "Изменные данные, занесенные в базу данных");
            Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
