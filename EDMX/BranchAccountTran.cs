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
    
    public partial class BranchAccountTran
    {
        public decimal UID { get; set; }
        public decimal Branch_UID { get; set; }
        public int TransactionNumber { get; set; }
        public int TransactionsTypeM_UID { get; set; }
        public string DocumentDetails { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public decimal AccountMGroups_UID { get; set; }
        public string Remarks { get; set; }
        public decimal CreatedUser_UID { get; set; }
        public decimal ApprovedUser_UID { get; set; }
        public decimal LogInfoStatus_UID { get; set; }
        public bool SalesType { get; set; }
        public int Finyear { get; set; }
    }
}
