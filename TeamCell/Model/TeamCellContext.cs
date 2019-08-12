using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Model
{
   public class TeamCellContext : DbContext
    {
       public TeamCellContext()
           : base("TeamCellContext")
       {
           //Database.SetInitializer<TeamCellContext>(new DropCreateDatabaseAlways<TeamCellContext>());
       }
       public  DbSet<Employee> Employee { get; set; }
       public DbSet<Client> Client { get; set; }
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           new Employee.Map(ref modelBuilder);
           new Client.Map(ref modelBuilder);

           base.OnModelCreating(modelBuilder);
       }
    }
}
