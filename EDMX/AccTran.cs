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
    
    public partial class AccTran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccTran()
        {
            this.AccTransLists = new HashSet<AccTransList>();
        }
    
        public decimal UID { get; set; }
        public decimal Branch_UID { get; set; }
        public int FinYear { get; set; }
        public int DocumentTypeM_UID { get; set; }
        public int TransactionsTypeM_UID { get; set; }
        public int DocumentNumber { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public System.DateTime SystemDate { get; set; }
        public string RefDocumentNumber { get; set; }
        public System.DateTime RefDocumentDate { get; set; }
        public decimal StatusM_UID { get; set; }
        public string StatusReason { get; set; }
        public string LongDocumentNo { get; set; }
        public int ViewType { get; set; }
        public string AddlInformation { get; set; }
        public bool ChequeRequired { get; set; }
        public decimal CreatedUser_UID { get; set; }
        public decimal ModifyUser_UID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccTransList> AccTransLists { get; set; }
    }
}
