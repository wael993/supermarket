//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace supermarket
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Order_Id { get; set; }
        public System.DateTime Order_date { get; set; }
        public Nullable<int> Employee_id { get; set; }
        public Nullable<int> Item_ID { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Item Item { get; set; }
    }
}