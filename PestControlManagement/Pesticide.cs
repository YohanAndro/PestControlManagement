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
    
    public partial class Pesticide
    {
        public System.Guid ID { get; set; }
        public System.Guid TechnicianID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Quantity { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public int IsActive { get; set; }
    }
}
