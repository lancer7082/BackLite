//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackLite.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountCode
    {
        public int CodeId { get; set; }
        public int AccountId { get; set; }
        public string Code { get; set; }
        public bool IsRegistered { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
