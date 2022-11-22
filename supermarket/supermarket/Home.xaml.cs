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

namespace supermarket
{
    /// <summary>
    /// Interaktionslogik für Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Employees_Mang_Grid.Visibility = Visibility.Hidden;
            Home_Grid.Visibility = Visibility.Visible;
            New_Billing_Grid.Visibility = Visibility.Hidden;
        }

        private void New_Billing_Click(object sender, RoutedEventArgs e)
        {
            Employees_Mang_Grid.Visibility = Visibility.Hidden;
            Home_Grid.Visibility = Visibility.Hidden;
            New_Billing_Grid.Visibility = Visibility.Visible;

        }
        private void Employees_Mang_Click(object sender, RoutedEventArgs e)
        {
            Home_Grid.Visibility = Visibility.Hidden;
            New_Billing_Grid.Visibility = Visibility.Hidden;
            Employees_Mang_Grid.Visibility = Visibility.Visible;
        }

        private void LV_New_Billing_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bestellung_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

      
    }
}
