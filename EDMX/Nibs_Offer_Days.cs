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
    
    public partial class Nibs_Offer_Days
    {
        public int DayId { get; set; }
        public int OfferId { get; set; }
        public string Days { get; set; }
    
        public virtual Nibs_Offer Nibs_Offer { get; set; }
    }
}
