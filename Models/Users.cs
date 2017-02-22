using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Users
    {
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
        public int IsActive { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogOutTime { get; set; }

    }
}
