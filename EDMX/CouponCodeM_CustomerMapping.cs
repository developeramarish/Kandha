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
    
    public partial class CouponCodeM_CustomerMapping
    {
        public decimal UID { get; set; }
        public decimal CouponCodeM_UID { get; set; }
        public decimal AccountM_UID { get; set; }
        public int CouponCount { get; set; }
        public int CouponUsed { get; set; }
    
        public virtual CouponCodeM CouponCodeM { get; set; }
    }
}
