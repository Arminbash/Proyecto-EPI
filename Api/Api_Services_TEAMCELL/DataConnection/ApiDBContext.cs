using Api_Services_TEAMCELL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Services_TEAMCELL.DataConnection
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext (DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelB)
        {
            new Employee.Map(modelB.Entity<Employee>().ToTable("Employee",schema :"RRHH"));
            new User.Map(modelB.Entity<User>().ToTable("Users", schema: "Users"));

            base.OnModelCreating(modelB);
        }

    }
}
