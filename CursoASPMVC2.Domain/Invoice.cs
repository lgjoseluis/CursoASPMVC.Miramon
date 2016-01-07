//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CursoASPMVC2.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.InvoiceLines = new HashSet<InvoiceLine>();
        }
    
        public int InvoiceId { get; set; }
        public int CompanyId { get; set; }
        public int CustomerId { get; set; }
        public string Reference { get; set; }
        public System.DateTime Date { get; set; }
        public bool IsRegistered { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
    }
}
