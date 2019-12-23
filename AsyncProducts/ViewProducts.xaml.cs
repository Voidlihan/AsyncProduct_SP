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

namespace AsyncProducts
{
    /// <summary>
    /// Interaction logic for ViewProducts.xaml
    /// </summary>
    public partial class ViewProducts : Window
    {
        public ViewProducts()
        {
            InitializeComponent();
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.ShowDialog();
        }

        private void TechSelect(object sender, RoutedEventArgs e)
        {
            using (var context = new Context()) {
                listBoxProducts.Items.Add(context.Products);
                context.SaveChanges();
            }
            if (listBoxProducts.SelectedItem != null)
            {             
                listBoxItemTech.Content = (listBoxProducts.SelectedItem as Product).Name;
            }
        }

        private void ComplectSelect(object sender, RoutedEventArgs e)
        {
            using (var context = new Context()) {
                listBoxProducts.Items.Add(context.Products);
                context.SaveChanges();
            }
            if (listBoxProducts.SelectedItem != null)
            {
                listBoxItemComplect.Content = (listBoxProducts.SelectedItem as Product).Name;
            }
        }
    }
}
