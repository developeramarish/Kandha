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
    
    public partial class tblConsumption
    {
        public int Id { get; set; }
        public int BillDetailId { get; set; }
        public int RawMaterialId { get; set; }
        public decimal Qty { get; set; }
        public decimal Value { get; set; }
    
        public virtual tbl_RawMaterials tbl_RawMaterials { get; set; }
        public virtual tblBillDetail tblBillDetail { get; set; }
    }
}