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
        public int TextID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string QuoteInd { get; set; }
        public string CountsWithQuotesID { get; set; }
        public string CountsWithoutQuotesID { get; set; }
    
        public virtual Count Count { get; set; }
        public virtual Text_Group Text_Group { get; set; }
    }
}
