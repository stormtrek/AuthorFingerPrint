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
    
    public partial class Text
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Text()
        {
            this.Text_Grouping = new HashSet<Text_Grouping>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public long IncludeQuotes { get; set; }
        public long WithQuotesId { get; set; }
        public long WithoutQuotesId { get; set; }
    
        public virtual WordCount WordCount { get; set; }
        public virtual WordCount WordCount1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Text_Grouping> Text_Grouping { get; set; }
    }
}
