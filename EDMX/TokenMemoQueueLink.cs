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
    
    public partial class TokenMemoQueueLink
    {
        public decimal UID { get; set; }
        public decimal BillTrans_UID { get; set; }
        public decimal BillTransListUID { get; set; }
        public decimal ItemsM_UID { get; set; }
        public System.DateTime RequestedTime { get; set; }
        public decimal FromTokenNo { get; set; }
        public decimal ToTokenNo { get; set; }
        public decimal RecCount { get; set; }
        public bool IsRunningOrder { get; set; }
        public string ItemString { get; set; }
        public int TokenGenerationType { get; set; }
        public Nullable<decimal> StatusM_UID { get; set; }
    }
}
