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
    
    public partial class Billing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Billing()
        {
            this.Billing_Item = new HashSet<Billing_Item>();
        }
    
        public int Billing_id { get; set; }
        public System.DateTime Billing_date { get; set; }
        public Nullable<int> Customer_id { get; set; }
        public Nullable<int> Item_ID { get; set; }
        public Nullable<int> Employee_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billing_Item> Billing_Item { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Item Item { get; set; }
    }
}
