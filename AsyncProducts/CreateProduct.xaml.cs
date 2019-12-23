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
    /// Interaction logic for CreateProduct.xaml
    /// </summary>
    public partial class CreateProduct : Window
    {
        public CreateProduct()
        {
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            using(var context = new Context())
            {
                var product = new Product()
                {
                    Name = textBoxProductNameAdd.Text,
                    Category = Guid.Parse(textBoxProductCategoryAdd.Text),
                    Price = int.Parse(textBoxProductPriceAdd.Text)
                };
                context.SaveChanges();
            }            
        }
    }
}
