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
    
    public partial class RoomBillAdvance
    {
        public decimal UID { get; set; }
        public decimal RoomBillTrans_UID { get; set; }
        public bool AdvanceType { get; set; }
        public decimal Amount { get; set; }
        public decimal StatusM_UID { get; set; }
        public bool IsCheque { get; set; }
        public string ChequeDetails { get; set; }
        public decimal ReceiptNo { get; set; }
        public System.DateTime ReceiptDate { get; set; }
        public System.DateTime Createdate { get; set; }
        public Nullable<decimal> RoomAllocationTrans_UID { get; set; }
    
        public virtual RoomBillTran RoomBillTran { get; set; }
    }
}
