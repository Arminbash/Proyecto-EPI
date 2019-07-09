using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Services_TEAMCELL.Models
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public DateTime BirthDay { get; set; }
        public string IdentificationCard { get; set; }
        public string State { get; set; }
        public bool Status { get; set; }

        public class Map
        {
            public Map(EntityTypeBuilder<Employee> ebEmployee)
            {
                ebEmployee.HasKey(x => x.IdEmployee);
                ebEmployee.Property(x => x.FirstName).HasColumnName("FirstName").HasMaxLength(50);
                ebEmployee.Property(x => x.SecondName).HasColumnName("SecondName").HasMaxLength(50);
                ebEmployee.Property(x => x.FirstSurname).HasColumnName("FirstSurname").HasMaxLength(50);
                ebEmployee.Property(x => x.SecondSurname).HasColumnName("SecondSurname").HasMaxLength(50);
                ebEmployee.Property(x => x.BirthDay).HasColumnName("BirthDay").HasColumnType("Datetime");
                ebEmployee.Property(x => x.IdentificationCard).HasColumnName("IdentificationCard").HasMaxLength(100);
                ebEmployee.Property(x => x.State).HasColumnName("State").HasMaxLength(50);
                ebEmployee.Property(x => x.Status).HasColumnName("Status").HasColumnType("bit");

            }
        }
    }
}
