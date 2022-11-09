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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace supermarket
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UserName_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Pass_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordUnmask.Text = Pass.Password;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PasswordUnmask.Visibility = Visibility.Visible;
            Pass.Visibility = Visibility.Hidden;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordUnmask.Visibility = Visibility.Hidden;
            Pass.Visibility = Visibility.Visible;
        }
    }
}
