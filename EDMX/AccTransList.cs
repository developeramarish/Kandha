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
    
    public partial class AccTransList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccTransList()
        {
            this.AccTransListBranchLists = new HashSet<AccTransListBranchList>();
            this.AccTransListCostCentres = new HashSet<AccTransListCostCentre>();
        }
    
        public decimal UID { get; set; }
        public decimal Branch_UID { get; set; }
        public decimal FinYear { get; set; }
        public decimal AccTrans_UID { get; set; }
        public decimal AccountMGroups_UID { get; set; }
        public bool IsHeader { get; set; }
        public int TransactionOrder { get; set; }
        public Nullable<decimal> Dr { get; set; }
        public Nullable<decimal> Cr { get; set; }
        public int GroupOrder { get; set; }
        public string Narration { get; set; }
        public decimal Control_AccountM_UID { get; set; }
        public Nullable<decimal> AdjustedAmount { get; set; }
        public string RefDocNo { get; set; }
        public Nullable<System.DateTime> RefDocDate { get; set; }
        public Nullable<decimal> TDSMasterM_UID { get; set; }
    
        public virtual AccountMGroup AccountMGroup { get; set; }
        public virtual AccTran AccTran { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccTransListBranchList> AccTransListBranchLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccTransListCostCentre> AccTransListCostCentres { get; set; }
    }
}
