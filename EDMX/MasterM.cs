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
    
    public partial class MasterM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterM()
        {
            this.EXP_MasterM = new HashSet<EXP_MasterM>();
            this.PriceGroupMappings = new HashSet<PriceGroupMapping>();
        }
    
        public decimal UID { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int AccountType { get; set; }
        public decimal Percentage { get; set; }
        public decimal AccountM_UID { get; set; }
        public bool IsWeighmentRequired { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXP_MasterM> EXP_MasterM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceGroupMapping> PriceGroupMappings { get; set; }
    }
}
