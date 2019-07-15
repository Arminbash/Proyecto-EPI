using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IdEmployee { get; set; }
        public bool Active { get; set; }
    }
}
