//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FingerPrint
{
    using System;
    using System.Collections.Generic;
    
    public partial class WordCount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WordCount()
        {
            this.Texts = new HashSet<Text>();
            this.Texts1 = new HashSet<Text>();
        }
    
        public long Id { get; set; }
        public long One { get; set; }
        public long Two { get; set; }
        public long Three { get; set; }
        public long Four { get; set; }
        public long Five { get; set; }
        public long Six { get; set; }
        public long Seven { get; set; }
        public long Eight { get; set; }
        public long Nine { get; set; }
        public long Ten { get; set; }
        public long Eleven { get; set; }
        public long Twelve { get; set; }
        public long Thirteen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Text> Texts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Text> Texts1 { get; set; }
    }
}