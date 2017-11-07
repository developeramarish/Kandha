//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NibsMVC.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class KOTTran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KOTTran()
        {
            this.BillTrans = new HashSet<BillTran>();
            this.KOTTrans_EmployeeXferDetails = new HashSet<KOTTrans_EmployeeXferDetails>();
        }
    
        public decimal UID { get; set; }
        public Nullable<decimal> Branch_UID { get; set; }
        public decimal AccountM_UID { get; set; }
        public int DocumentTypeM_UID { get; set; }
        public int FinYear { get; set; }
        public System.DateTime KOTDate { get; set; }
        public decimal Table_UID { get; set; }
        public Nullable<decimal> Waiter_UID { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> StatusM_UID { get; set; }
        public Nullable<decimal> ShiftM_UID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string TableSplit { get; set; }
        public decimal Operator_UID { get; set; }
        public int NoofPersons { get; set; }
    
        public virtual AccountM AccountM { get; set; }
        public virtual AccountM AccountM1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillTran> BillTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KOTTrans_EmployeeXferDetails> KOTTrans_EmployeeXferDetails { get; set; }
        public virtual TableM TableM { get; set; }
    }
}
