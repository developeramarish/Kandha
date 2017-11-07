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
    
    public partial class Promo_Header
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Promo_Header()
        {
            this.Promo_BOGO_Header = new HashSet<Promo_BOGO_Header>();
            this.Promo_BOGO_List = new HashSet<Promo_BOGO_List>();
            this.Promo_Items_Price = new HashSet<Promo_Items_Price>();
            this.Promo_Items = new HashSet<Promo_Items>();
            this.Promo_Validity = new HashSet<Promo_Validity>();
            this.Promo_Value = new HashSet<Promo_Value>();
        }
    
        public decimal UID { get; set; }
        public string PromoCode { get; set; }
        public string PromoDescription { get; set; }
        public string PromoType { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public decimal CreatedBy_UID { get; set; }
        public System.DateTime ModifiedDateTime { get; set; }
        public decimal ModifiedBy_UID { get; set; }
        public string Promo_Offer_Desc { get; set; }
        public decimal Hall_UID { get; set; }
        public decimal Branch_UID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promo_BOGO_Header> Promo_BOGO_Header { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promo_BOGO_List> Promo_BOGO_List { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promo_Items_Price> Promo_Items_Price { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promo_Items> Promo_Items { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promo_Validity> Promo_Validity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promo_Value> Promo_Value { get; set; }
    }
}
