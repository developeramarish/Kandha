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
    
    public partial class AccTransListCostCentre
    {
        public decimal UID { get; set; }
        public decimal AccTransList_UID { get; set; }
        public decimal CostCentreM_UID { get; set; }
        public Nullable<decimal> Dr { get; set; }
        public Nullable<decimal> Cr { get; set; }
        public string Narration { get; set; }
        public string Reference { get; set; }
        public Nullable<decimal> Branch_UID { get; set; }
    
        public virtual AccTransList AccTransList { get; set; }
    }
}