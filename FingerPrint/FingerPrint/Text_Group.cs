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
    
    public partial class Text_Group
    {
        public int TextID { get; set; }
        public int GroupID { get; set; }
        public int TextTextID { get; set; }
    
        public virtual Text Text { get; set; }
        public virtual Group Group { get; set; }
    }
}
