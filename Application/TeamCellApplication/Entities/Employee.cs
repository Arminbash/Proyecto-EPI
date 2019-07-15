using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public string IdentificationCard { get; set; }
        public string State { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
