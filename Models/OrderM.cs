//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GariLagbe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderM()
        {
            this.Payments = new HashSet<Payment>();
        }
    
        public int Order_ID { get; set; }
        public int Customer_ID { get; set; }
        public int Vehicle_ID { get; set; }
        public Nullable<int> Order_RentHour { get; set; }
        public string Order_FromLocation { get; set; }
        public string Order_ToLocation { get; set; }
        public Nullable<double> Order_TotalPrice { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
