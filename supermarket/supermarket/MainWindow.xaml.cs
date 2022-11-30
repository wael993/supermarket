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
      //  test test = new test();
       

        Home home = new Home();
        public MainWindow()
        {
            home.Show();
            InitializeComponent();
        }
        private void Pass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordUnmask.Text = Pass.Password;
        }



        private void Showpass_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PasswordUnmask.Visibility = Visibility.Visible;
            Pass.Visibility = Visibility.Hidden;
            Showpass.Visibility = Visibility.Hidden;
            hidpass.Visibility = Visibility.Visible;
        }

        private void hidpass_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PasswordUnmask.Visibility = Visibility.Hidden;
            Pass.Visibility = Visibility.Visible;
            Showpass.Visibility = Visibility.Visible;
            hidpass.Visibility = Visibility.Hidden;

        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            using(supermarketEntities1 SPE =new supermarketEntities1())
            {
                var list = SPE.Employees.Where(x => x.Username == UserName.Text && x.Password == Pass.Password).ToList();
                foreach (var Epm in list)
                {
                    Close();
                    home.Show();
                    return;
                }

                MessageBox.Show("username or password is incorrect!");
            }

        }

   
    }
}
