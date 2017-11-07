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
    
    public partial class VT_PurchaseOrderOpen
    {
        public decimal UID { get; set; }
        public decimal Branch_UID { get; set; }
        public int FinYear { get; set; }
        public string DocumentNumber { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public System.DateTime SystemDate { get; set; }
        public decimal Partners_UID { get; set; }
        public string PartnerName { get; set; }
        public decimal StatusM_UID { get; set; }
        public string StatusReason { get; set; }
        public string LongDocumentNo { get; set; }
        public string RefDocumentNumber { get; set; }
        public Nullable<System.DateTime> RefDocumentDate { get; set; }
        public string AdditionalInformation { get; set; }
        public decimal OrderTransList_UID { get; set; }
        public decimal Items_UID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public int OrderTransList_StatusM_UID { get; set; }
        public Nullable<decimal> BalanceQty { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public string OrderTransList_AdditionalInformation { get; set; }
        public string ItemUOM { get; set; }
        public string LongItemName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string PinCode { get; set; }
        public string Phone { get; set; }
        public string RefDocumentNumber1 { get; set; }
        public Nullable<System.DateTime> RefDocumentDate1 { get; set; }
        public decimal Discount { get; set; }
        public decimal ED { get; set; }
        public decimal EDCess { get; set; }
        public decimal EDHECess { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal ServiceTax { get; set; }
        public decimal ServiceTaxCess { get; set; }
        public decimal ServiceTaxHECess { get; set; }
        public decimal CST { get; set; }
        public decimal VAT { get; set; }
        public decimal TotalValue { get; set; }
        public decimal TotalValueRoundOff { get; set; }
        public int AmendmentNo { get; set; }
        public System.DateTime AmendmentDate { get; set; }
        public string AmendmentReason { get; set; }
        public decimal DespatchTo_UID { get; set; }
        public string DespatchTo_PartnerName { get; set; }
        public string DespatchTo_Address1 { get; set; }
        public string DespatchTo_Address2 { get; set; }
        public string DespatchTo_Address3 { get; set; }
        public string DespatchTo_Address4 { get; set; }
        public string DespatchTo_Address5 { get; set; }
        public string DespatchTo_PinCode { get; set; }
        public string DespatchTo_Phone { get; set; }
        public decimal UOM_UID { get; set; }
        public decimal Price { get; set; }
        public decimal BasicValue { get; set; }
        public decimal BasicDiscountPer { get; set; }
        public decimal BasicDiscountAmount { get; set; }
        public decimal EDID { get; set; }
        public decimal EDPer { get; set; }
        public decimal EDAmount { get; set; }
        public decimal CessID { get; set; }
        public decimal CessPer { get; set; }
        public decimal CessAmount { get; set; }
        public decimal HECessID { get; set; }
        public decimal HECessPer { get; set; }
        public decimal HECessAmount { get; set; }
        public decimal VATCategoryID { get; set; }
        public decimal VATID { get; set; }
        public decimal VATPer { get; set; }
        public decimal VATAmount { get; set; }
        public decimal CSTID { get; set; }
        public decimal CSTPer { get; set; }
        public decimal CSTAmount { get; set; }
        public decimal OrderTransList_TotalValue { get; set; }
    }
}
