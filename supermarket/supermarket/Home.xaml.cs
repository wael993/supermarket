﻿using System;
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
        private ICollectionView icollectionwiew ;
        supermarketEntities ctx = new supermarketEntities();
        public Home()
        {
            InitializeComponent();
            ctx.Billing.Load();
            icollectionwiew = CollectionViewSource.GetDefaultView(ctx.Billing.Local);



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

        }
        private void Employees_Mang_Click(object sender, RoutedEventArgs e)
        {
            Home_Grid.Visibility = Visibility.Hidden;
            New_Billing_Grid.Visibility = Visibility.Hidden;
            Employees_Mang_Grid.Visibility = Visibility.Visible;
            Item_Mang_Grid.Visibility = Visibility.Hidden;
        }
        private void Items_Mang_Click(object sender, RoutedEventArgs e)
        {
            Item_Mang_Grid.Visibility = Visibility.Visible;
            Home_Grid.Visibility = Visibility.Hidden;
            New_Billing_Grid.Visibility = Visibility.Hidden;
            Employees_Mang_Grid.Visibility = Visibility.Hidden;
        }
        private void LV_New_Billing_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bestellung_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

       
    }
}
