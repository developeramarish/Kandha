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
    
    public partial class AddCategoryVendor
    {
        public int id { get; set; }
        public int RawCategoryId { get; set; }
        public int VendorId { get; set; }
    
        public virtual RawCategory RawCategory { get; set; }
        public virtual tblVendor tblVendor { get; set; }
    }
}
