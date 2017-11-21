//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NibsMVC.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDeleteBillMaster
    {
        public tblDeleteBillMaster()
        {
            this.tblDeletedetails = new HashSet<tblDeletedetail>();
        }
    
        public int DeleteId { get; set; }
        public System.DateTime BillDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal VatAmount { get; set; }
        public decimal ServiceCharAmt { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string TableNo { get; set; }
        public string CustomerName { get; set; }
        public int OutletId { get; set; }
        public string BillingType { get; set; }
        public Nullable<int> TokenNo { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public int BillNo { get; set; }
        public string PaymentType { get; set; }
        public string ChequeNo { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public string ContactNo { get; set; }
        public Nullable<decimal> PackingCharges { get; set; }
        public Nullable<decimal> ServiceTax { get; set; }
    
        public virtual tblOutlet tblOutlet { get; set; }
        public virtual ICollection<tblDeletedetail> tblDeletedetails { get; set; }
    }
}