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
    /// Interaktionslogik für test.xaml
    /// </summary>
    public partial class test : Window
    {
        List<Billing_Item> Rechnungspositionen;

        private ICollectionView icollectionwiew;
        supermarketEntities1 ctx = new supermarketEntities1();
        List<Billing_Item> BestellungAufnehmen_Rechnungsposten = new List<Billing_Item>();

        public test()
        {
            InitializeComponent();
            ctx.Item.Load();
            SpeiseAufnehmen.DataContext = ctx.Item.ToList();
            Bestellung.DataContext = BestellungAufnehmen_Rechnungsposten;
        }

        private void Delete(object sender, MouseButtonEventArgs e)
        {
            Billing_Item re = (Billing_Item)Bestellung.SelectedItem;
            if (re.Quantity == 1)
            {
                BestellungAufnehmen_Rechnungsposten.Remove(re);
            }
            re.Quantity--;
          //  Gesamt();
            Bestellung.DataContext = null;
            Bestellung.DataContext = BestellungAufnehmen_Rechnungsposten;
        }

        private void Rechnung_Speichern(object sender, RoutedEventArgs e)
        {

            if (ID_Mitarbeiter.Text == "")
            {
                MessageBox.Show("MiTarbeiter ID!");
            }
            else if (Tischnummer.Text == "")
            {
                MessageBox.Show("Tischnummer!");
            }
            else
            {
                Billing neueRechnung = new Billing();
                neueRechnung.Employee_id = Convert.ToInt32(ID_Mitarbeiter.Text);
                //neueRechnung.Rechnung_status = "bezahlt";
                neueRechnung.Customer_id = Convert.ToInt32(Tischnummer.Text);
                neueRechnung.Billing_date = DateTime.Now;
                ctx.Billing.Add(neueRechnung);
                ctx.SaveChanges();
                int id = neueRechnung.Billing_id;
                foreach (var v in BestellungAufnehmen_Rechnungsposten)
                {
                    v.Billing_id = id;
                    ctx.Billing_Item.Add(v);
                }
                ctx.SaveChanges();

                ID_Mitarbeiter.Text = "";
                Tischnummer.Text = "";
                BestellungAufnehmen_Rechnungsposten.Clear();
                Bestellung.DataContext = null;
                Bestellung.DataContext = BestellungAufnehmen_Rechnungsposten;
                Rechnungskosten.Text = "";
            }
        }

        private void RechnungAufnehmen(object sender, MouseButtonEventArgs e)
        {
            Billing_Item re = new Billing_Item();
            Item s = (Item)SpeiseAufnehmen.SelectedItem;
            if (BestellungAufnehmen_Rechnungsposten != null && BestellungAufnehmen_Rechnungsposten.Any(x => x.Item.Item_ID == s.Item_ID))
            {
                re = BestellungAufnehmen_Rechnungsposten.FirstOrDefault(x => x.Item.Item_ID == s.Item_ID);
                re.Quantity++;
            }
            else
            {
                re.Item = s;
                re.Quantity = 1;
                BestellungAufnehmen_Rechnungsposten.Add(re);
            }
          //  Gesamt();
            Bestellung.DataContext = null;
            Bestellung.DataContext = BestellungAufnehmen_Rechnungsposten;
        }
        //private void Gesamt()
        //{
        //    decimal total = 0;
        //    foreach (Billing_Item pos in BestellungAufnehmen_Rechnungsposten)
        //    {
        //        total += pos.Item.Price * pos.Quantity;
        //    }
        //    Rechnungskosten.Text = Convert.ToString(total);
        //}
        private void Button_ZumHauptmenü(object sender, RoutedEventArgs e)
        {

        }
    }
}
