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
    
    public partial class BillMemoQueue_LocalMachine
    {
        public decimal BillTrans_UID { get; set; }
        public Nullable<System.DateTime> RequestedTime { get; set; }
        public Nullable<decimal> StatusM_UID { get; set; }
        public Nullable<decimal> Branch_UID { get; set; }
        public Nullable<bool> IsColleted { get; set; }
        public Nullable<bool> IsDuplicateBill { get; set; }
        public bool IsMemoNeeded { get; set; }
        public int BillType { get; set; }
        public string MachineID { get; set; }
    }
}
