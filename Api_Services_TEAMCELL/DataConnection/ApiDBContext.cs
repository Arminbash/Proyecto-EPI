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

        protected override void OnModelCreating(ModelBuilder modelB)
        {
            new Employee.Map(modelB.Entity<Employee>());

            base.OnModelCreating(modelB);
        }

    }
}
