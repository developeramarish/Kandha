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
    
    public partial class CommodityM_ServiceTaxMaster_Mapping
    {
        public decimal UID { get; set; }
        public decimal CommodityUID { get; set; }
        public decimal ServiceTaxMaster_UID { get; set; }
    
        public virtual AccountM AccountM { get; set; }
        public virtual ServiceTaxMaster ServiceTaxMaster { get; set; }
    }
}
