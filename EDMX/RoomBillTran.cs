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
    
    public partial class RoomBillTran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomBillTran()
        {
            this.RoomBillAdvances = new HashSet<RoomBillAdvance>();
            this.RoomBillTransLists = new HashSet<RoomBillTransList>();
        }
    
        public decimal UID { get; set; }
        public decimal Branch_UID { get; set; }
        public decimal BillNo { get; set; }
        public System.DateTime BillDate { get; set; }
        public decimal GuestsM_UID { get; set; }
        public System.DateTime CheckInDate { get; set; }
        public System.DateTime CheckOutDate { get; set; }
        public decimal Total { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal ServiceChargeTotal { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal NettTotal { get; set; }
        public string AddlNotes { get; set; }
        public string Remarks { get; set; }
        public decimal AllocationTrans_UID { get; set; }
        public decimal RoundOff { get; set; }
    
        public virtual GuestM GuestM { get; set; }
        public virtual RoomAllocationTran RoomAllocationTran { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomBillAdvance> RoomBillAdvances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomBillTransList> RoomBillTransLists { get; set; }
    }
}
