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
    
    public partial class KOTTrans_EmployeeXferDetails
    {
        public decimal UID { get; set; }
        public decimal KOTTrans_UID { get; set; }
        public System.DateTime FromBillDate { get; set; }
        public System.DateTime ToBillDate { get; set; }
        public decimal From_CaptainUID { get; set; }
        public decimal From_WaiterUID { get; set; }
        public decimal To_CaptainUID { get; set; }
        public decimal To_WaiterUID { get; set; }
        public decimal CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public decimal ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<decimal> ApprovedBy { get; set; }
        public Nullable<decimal> ApprovedStatus { get; set; }
    
        public virtual KOTTran KOTTran { get; set; }
    }
}
