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
    
    public partial class PaymentType
    {
        public decimal UID { get; set; }
        public decimal BillTrans_UID { get; set; }
        public decimal PaymentType_UID { get; set; }
        public Nullable<bool> PaymentMode { get; set; }
        public Nullable<bool> CardType { get; set; }
        public Nullable<decimal> Rooms_UID { get; set; }
        public Nullable<decimal> CardNumber { get; set; }
        public Nullable<decimal> CouponType_UID { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<decimal> Bank_UID { get; set; }
        public Nullable<decimal> Customer_UID { get; set; }
        public string CustomerName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Nullable<decimal> Mobile { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<bool> IsRefunded { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> CreatedBy { get; set; }
        public decimal TndrAmt { get; set; }
        public decimal Tip { get; set; }
        public decimal CardType_UID { get; set; }
        public Nullable<decimal> CardUID { get; set; }
        public Nullable<decimal> Currency_UID { get; set; }
        public Nullable<decimal> Currency_Value { get; set; }
        public Nullable<decimal> Exchange_Rate { get; set; }
    }
}
