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
    
    public partial class tblOpStckRate
    {
        public int id { get; set; }
        public int MaterialId { get; set; }
        public decimal Rate { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> IssQty { get; set; }
    
        public virtual tbl_RawMaterials tbl_RawMaterials { get; set; }
    }
}
