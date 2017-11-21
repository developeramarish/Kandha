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
    
    public partial class tblPurchaseMaster
    {
        public int PurchaseId { get; set; }
        public int InvoiceNo { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Tax { get; set; }
        public decimal NetAmount { get; set; }
        public decimal ExtraCharge { get; set; }
        public string ExtraChargeDetails { get; set; }
        public int OutletId { get; set; }
        public Nullable<int> VendorId { get; set; }
        public Nullable<decimal> DepositeAmount { get; set; }
        public Nullable<decimal> RemainingAmount { get; set; }
        public string PaymenyMode { get; set; }
        public string ChequeNo { get; set; }
        public int PurchaseOrderId { get; set; }
        public string Remarks { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual tblVendor tblVendor { get; set; }
    }
}