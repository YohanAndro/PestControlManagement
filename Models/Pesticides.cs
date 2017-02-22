using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pesticides
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
        public int IsActive { get; set; }
    }
}
