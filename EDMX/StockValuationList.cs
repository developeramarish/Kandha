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
    
    public partial class StockValuationList
    {
        public decimal UID { get; set; }
        public int StockValuationTypeID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public decimal AccountMGroups_UID { get; set; }
        public decimal ReceiptStockTransList_UID { get; set; }
        public decimal IssueStockTransList_UID { get; set; }
        public decimal AccountMItems_UID { get; set; }
        public decimal Qty { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> StockValue { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
    }
}