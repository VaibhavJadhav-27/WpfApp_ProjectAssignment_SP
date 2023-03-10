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
    
    public partial class V_MST_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public V_MST_Product()
        {
            this.V_MST_ProductSpecification = new HashSet<V_MST_ProductSpecification>();
            this.V_MST_Category = new HashSet<V_MST_Category>();
        }
    
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductImage { get; set; }
        public int BrandId { get; set; }
    
        public virtual V_DEV_ProductType V_DEV_ProductType { get; set; }
        public virtual V_MST_Brand V_MST_Brand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<V_MST_ProductSpecification> V_MST_ProductSpecification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<V_MST_Category> V_MST_Category { get; set; }
    }
}
