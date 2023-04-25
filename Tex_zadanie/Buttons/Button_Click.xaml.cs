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
    /// Логика взаимодействия для Button_Click.xaml
    /// </summary>
    public partial class Button_Click : Window
    {
        public Button_Click()
        {
            InitializeComponent();
            Product = new Product();
            DataContext = Product;
            Product.ID = Guid.NewGuid();
        }

        public Product Product { get; set; }

        private void Button_Click_1(object sender, RoutedEventArgs e) // добавить товар
        {

            try
            {
                Sqlite sqlite = new Sqlite();
                Product product = new Product
                {
                    Price = Product.Price,
                    Name = Product.Name,
                    ID = Product.ID,
                    Description = Product.Description
                };

                string show = "Уникальный идентификатор: " + Product.ID + "\r\n" + "Имя товара: " + Product.Name + "\r\n" + "Описание товара: " + Product.Description + "\r\n" + "Цена товара: " + Product.Price + " RUB";
                MessageBox.Show(show, "Данные, занесенные в базу данных");

                sqlite.Products.Add(product);
                sqlite.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();




        }

    }
}   