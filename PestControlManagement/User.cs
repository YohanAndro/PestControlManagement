//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PestControlManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public System.Guid ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public int IsActive { get; set; }
        public Nullable<System.DateTime> LoginTime { get; set; }
        public Nullable<System.DateTime> LogOutTime { get; set; }
    }
}