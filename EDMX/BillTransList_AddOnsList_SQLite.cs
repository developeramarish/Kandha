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
    
    public partial class BillTransList_AddOnsList_SQLite
    {
        public decimal UID { get; set; }
        public decimal BillTransList_SQLiteUID { get; set; }
        public decimal BillAddOnsListID { get; set; }
        public decimal BillID { get; set; }
        public decimal BillProductID { get; set; }
        public decimal AddOnProductID { get; set; }
        public decimal UOMID { get; set; }
        public decimal OrderQty { get; set; }
        public decimal BillQty { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductValue { get; set; }
        public System.DateTime OrderedTime { get; set; }
        public decimal StatusM_UID { get; set; }
        public string Remarks { get; set; }
    
        public virtual BillTransList_SQLite BillTransList_SQLite { get; set; }
    }
}
