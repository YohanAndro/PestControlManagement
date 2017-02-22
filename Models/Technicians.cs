using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Technicians
    {
        public System.Guid ID { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string TechnicianID { get; set; }
        public string EmailId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
        public int IsActive { get; set; }
    }
}
