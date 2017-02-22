using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Customer
   {
       public System.Guid ID { get; set; }
       public string Name { get; set; }
       public string MobileNo { get; set; }
       public string Phone { get; set; }
       public string Fax { get; set; }
       public string Email { get; set; }
       public string Address { get; set; }       
       public string CustomerType { get; set; }
       public DateTime Created { get; set; }
       public DateTime LastUpdated { get; set; }
       public int IsActive { get; set; }
    }
}
