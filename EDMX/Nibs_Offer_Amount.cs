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
    
    public partial class Nibs_Offer_Amount
    {
        public int AmtId { get; set; }
        public decimal Amount { get; set; }
        public int ItemId { get; set; }
        public decimal Discount { get; set; }
        public Nullable<int> Quantity { get; set; }
        public int OfferId { get; set; }
    
        public virtual Nibs_Offer Nibs_Offer { get; set; }
        public virtual tblItem tblItem { get; set; }
    }
}