using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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
        //private ICollectionView icollectionwiew ;
        supermarketEntities1 ctx = new supermarketEntities1();
        List<Billing_Item> Invoice_Item = new List<Billing_Item>();

        public Home()
        {
            InitializeComponent();
            //ctx.Billing.Load();
            //icollectionwiew = CollectionViewSource.GetDefaultView(ctx.Billing.Local);
            //vater.DataContext = icollectionwiew;
          
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Employees_Mang_Grid.Visibility = Visibility.Hidden;
            Home_Grid.Visibility = Visibility.Visible;
            Item_Mang_Grid.Visibility = Visibility.Hidden;
            New_Billing_Grid.Visibility = Visibility.Hidden;
        }

        private void New_Billing_Click(object sender, RoutedEventArgs e)
        {
            Employees_Mang_Grid.Visibility = Visibility.Hidden;
            Home_Grid.Visibility = Visibility.Hidden;
            New_Billing_Grid.Visibility = Visibility.Visible;
            Item_Mang_Grid.Visibility = Visibility.Hidden;
            ctx.Item.Load();
            New_Billing_Grid.DataContext = ctx.Item.ToList();
            Invoice.DataContext = Invoice_Item;
        }
        private void Employees_Mang_Click(object sender, RoutedEventArgs e)
        {
            Home_Grid.Visibility = Visibility.Hidden;
            New_Billing_Grid.Visibility = Visibility.Hidden;
            Employees_Mang_Grid.Visibility = Visibility.Visible;
            Item_Mang_Grid.Visibility = Visibility.Hidden;
            ctx.Employees.Load();
            Emp_mang.DataContext = ctx.Employees.ToList();
        }
        private void Items_Mang_Click(object sender, RoutedEventArgs e)
        {
            Item_Mang_Grid.Visibility = Visibility.Visible;
            Home_Grid.Visibility = Visibility.Hidden;
            New_Billing_Grid.Visibility = Visibility.Hidden;
            Employees_Mang_Grid.Visibility = Visibility.Hidden;
            ctx.Item.Load();
            Item_Mang.DataContext = ctx.Item.ToList();
        }
   

       
        private void Delete(object sender, MouseButtonEventArgs e)
        {
            Billing_Item re = (Billing_Item)Invoice.SelectedItem;
            if (re.Quantity == 1)
            {
                Invoice_Item.Remove(re);
            }
            re.Quantity--;
            //  Gesamt();
            Invoice.DataContext = null;
            Invoice.DataContext = Invoice_Item;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Coustemer_nr.Text == "")
            {
                MessageBox.Show("MiTarbeiter ID!");
            }
            else if (Quantity.Text == "")
            {
                MessageBox.Show("Tischnummer!");
            }
            else
            {
                Billing neueRechnung = new Billing();
                neueRechnung.Employee_id = Convert.ToInt32(Coustemer_nr.Text);
                //neueRechnung.Rechnung_status = "bezahlt";
                neueRechnung.Customer_id = Convert.ToInt32(Quantity.Text);
                neueRechnung.Billing_date = DateTime.Now;
                ctx.Billing.Add(neueRechnung);
                ctx.SaveChanges();
                int id = neueRechnung.Billing_id;
                foreach (var v in Invoice_Item)
                {
                    v.Billing_id = id;
                    ctx.Billing_Item.Add(v);
                }
                ctx.SaveChanges();

                Coustemer_nr.Text = "";
                Quantity.Text = "";
                Invoice_Item.Clear();
                Invoice.DataContext = null;
                Invoice.DataContext = Invoice_Item;
                Rechnungskosten.Text = "";
            }
        }

        private void LV_New_Billing_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Billing_Item re = new Billing_Item();
            Item s = (Item)LV_New_Billing.SelectedItem;
            if (Invoice_Item != null && Invoice_Item.Any(x => x.Item.Item_ID == s.Item_ID))
            {
                re = Invoice_Item.FirstOrDefault(x => x.Item.Item_ID == s.Item_ID);
                re.Quantity++;
            }
            else
            {
                re.Item = s;
                re.Quantity = 1;
                Invoice_Item.Add(re);
            }
            //  Gesamt();
            Invoice.DataContext = null;
            Invoice.DataContext = Invoice_Item;
        }
        private void Gesamt()
        {
            decimal total = 0;
            foreach (Billing_Item pos in Invoice_Item)
            {

                //total += pos.Item.Price * pos.Quantity;
            }
            Rechnungskosten.Text = Convert.ToString(total);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Billing_Item re = new Billing_Item();
            Item s = (Item)LV_New_Billing.SelectedItem;
            if (Invoice_Item != null && Invoice_Item.Any(x => x.Item.Item_ID == s.Item_ID))
            {
                re = Invoice_Item.FirstOrDefault(x => x.Item.Item_ID == s.Item_ID);
                re.Quantity++;
            }
            else
            {
                re.Item = s;
                re.Quantity = 1;
                Invoice_Item.Add(re);
            }
            //  Gesamt();
            Invoice.DataContext = null;
            Invoice.DataContext = Invoice_Item;
        }
    }
}
