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
    
    public partial class ImagesProduct
    {
        public int IdImage { get; set; }
        public int IdImageProduct { get; set; }
        public string Decription { get; set; }
        public byte[] Image { get; set; }
        public string DateUpdate { get; set; }
        public string IsEnabled { get; set; }
    
        public virtual Products Products { get; set; }
    }
}
