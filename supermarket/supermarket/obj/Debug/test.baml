   M S B A M L   `   `   `  ????F  Bsupermarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:supermarketsupermarket  5   	       supermarket.test   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:supermarket     5   	     ? Title$
  test??5   	   $	??450??6   $	??800??6#   .??5	      ? .+?5
   
   ??  ?? CornerRadius$ 6??6   $
??Left=?6#   $	??Top=?6>   $??60??6V   $??75??6b   $??20q?6m   $??1??6y   $??2q?6?   
???   ?._?5      ?? -   5        $??Menü??5      $??0q?6A   $??1q?6U   5      ? 5   
   -   5         ?Name$" MainGrid_Rechungen_erstellen??5       ? RowDefinitions 5      ?? 5      $??56 ?6    ?? 5      $
??293* ?6    ?? 5      $	??34* ?6    ?? 5      $??36 ?6     ? ColumnDefinitions 5      ?? 5      $	??100 ?6#   ?? 5      $	??74* ?6#   ?? 5      $	??95* ?6#   ?? 5      $??16 ?6#   .+?5      ?? $??Rechnungen erstellen??6   $??2??64   ?? 5      -   5         ??Name$ SpeiseAufnehmen??5      $??1??5      $ ?? IsSynchronizedWithCurrentItem$
 TrueY?5        ?? SelectedIndex$ 1??5!   ,   $??3??5"      $??0,47,0,1q?6(   ??5!      ?? ??5#      ?? 5$      .R?5%      ?? ?? 5&   "   ?6&   ?? *	Item_ID+ ?? 5'   "   $	? - ??6&    ?? 5(   "   ?6&   ?? *	Item_Name+ ?? 5)   "   $	? - ??6&    ?? 5*   "   ?6&   ?? *Price+ ?? 5+   "   $?(??6&    ?? 5,   "   ?6&   ?? *
Quantity+ ?? 5-   "   $?)??6&   5.      5/      51      ? 53      $??1??6   $??2??6%    ? 	Resources 54      	 ?? 
TargetType
 ?? Property ?? Value??%?   '??       ?? 55      "	 ??6   .?56      ?? 
 ? ??$ Center=?6G   ?? 57      
 ? ??$ Center=?6E   ?? 58      
 ? ??$	 100??62   59      5:      .+?5;      ?? $??10q?6   $??Mitarbeiter ID:??6(   ?? 5<      -   5         ??Name$ ID_Mitarbeiter??5<      ?? 5>      $??10q?6   $??Tischnummer:??6(   ?? 5?      -   5        $ Tischnummer??5?      &   System.Windows.Controls.DataGrid  5@      -   5        $??
Bestellung??5@   4      AutoGenerateColumns .     
IsReadOnly . ??6   ??    Columns 5A      0  *System.Windows.Controls.DataGridTextColumn  5B      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Produkt ID??6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ?? *Item.Item_ID+6b     5C      $
 Name??6-   $ * 6^    6;   ?? *Item.Item_Name+6^     5D      $ Anzahl??6-   $ * 6Z    6=   ?? *
Quantity+6Z     5E      $ Preis??6-   $ * 6[    6<   ?? *
Item.Price+6[   5G      ?? 5H      $??
Insgesamt:??6   $	??5,0q?6.   ?? 5I      -   5         ??Name$ Rechnungskosten??5I      ?? 5J      $	??€??6   5K      ?? 5L      -   5        $??2??5L      $??2??6%   $??Rechnung erstellen??6M   5N      5O      5P      