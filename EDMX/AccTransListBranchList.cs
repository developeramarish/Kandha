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
    
    public partial class AccTransListBranchList
    {
        public decimal UID { get; set; }
        public decimal Branch_UID { get; set; }
        public decimal FinYear { get; set; }
        public decimal AccTrans_UID { get; set; }
        public decimal AccTransList_UID { get; set; }
        public decimal AccountMGroups_UID { get; set; }
        public bool IsHeader { get; set; }
        public int TransactionOrder { get; set; }
        public Nullable<decimal> Dr { get; set; }
        public Nullable<decimal> Cr { get; set; }
        public int GroupOrder { get; set; }
        public string Narration { get; set; }
        public decimal Control_AccountM_UID { get; set; }
        public Nullable<decimal> AdjustedAmount { get; set; }
    
        public virtual AccountMGroup AccountMGroup { get; set; }
        public virtual AccTransList AccTransList { get; set; }
    }
}
