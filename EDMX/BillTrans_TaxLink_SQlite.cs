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
    
    public partial class BillTrans_TaxLink_SQlite
    {
        public decimal UID { get; set; }
        public decimal BillTrans_SQLiteUID { get; set; }
        public decimal BillID { get; set; }
        public decimal VAT_UID { get; set; }
        public string VATItemDetails { get; set; }
        public decimal VATAmount { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual BillTrans_SQLite BillTrans_SQLite { get; set; }
    }
}
