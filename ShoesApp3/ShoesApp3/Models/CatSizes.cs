//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesApp3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CatSizes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatSizes()
        {
            this.SizeForProduct = new HashSet<SizeForProduct>();
        }
    
        public int IdSize { get; set; }
        public int IdType { get; set; }
        public string Code { get; set; }
        public string Unity { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SizeForProduct> SizeForProduct { get; set; }
        public virtual CatTypeProduct CatTypeProduct { get; set; }
    }
}
