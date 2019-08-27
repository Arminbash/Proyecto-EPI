using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
  public  class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public DateTime Date { get; set; }
        public decimal Preci { get; set; }
        public decimal Cost { get; set; }
        public int Existence { get; set; }
        public bool Status { get; set; }

        public class Map
        {
            public Map (ref DbModelBuilder modelbuilder)
            {
                modelbuilder.HasDefaultSchema("Product");
                modelbuilder.Entity<Product>().ToTable("Product");

                modelbuilder.Entity<Product>().HasKey<int>(s => s.IdProduct);
                modelbuilder.Entity<Product>().Property(x => x.IdProduct).HasColumnName("IdProduct");
                modelbuilder.Entity<Product>().Property(x => x.NameProduct).HasColumnName("NameProduct").HasMaxLength(50);
                modelbuilder.Entity<Product>().Property(x => x.Date).HasColumnName("Date").HasColumnType("DateTime");
                modelbuilder.Entity<Product>().Property(x => x.Preci).HasColumnName("Preci").HasColumnType("Decimal");
                modelbuilder.Entity<Product>().Property(x => x.Cost).HasColumnName("Cost").HasColumnType("Decimal");
                modelbuilder.Entity<Product>().Property(x => x.Existence).HasColumnName("Existence").HasColumnType("int");
                modelbuilder.Entity<Product>().Property(x => x.Status).HasColumnName("Status").HasColumnType("bit");
            }
        }
    }
}
