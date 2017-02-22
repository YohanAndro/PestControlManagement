using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PestControlManagement
{
    public class CustmerTeche
    {
        public System.Guid ID { get; set; }
        public string TechnicianID { get; set; }
        public string TechnicianName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public string Comments { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public int IsActive { get; set; }
    }
}
