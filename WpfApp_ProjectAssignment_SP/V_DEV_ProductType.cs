//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp_ProjectAssignment_SP
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_DEV_ProductType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public V_DEV_ProductType()
        {
            this.V_MST_Product = new HashSet<V_MST_Product>();
        }
    
        public int ProductTypeId { get; set; }
        public string ProductType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<V_MST_Product> V_MST_Product { get; set; }
    }
}