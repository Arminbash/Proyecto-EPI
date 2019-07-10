using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Services_TEAMCELL.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public byte[]   Salt { get; set; }
        public byte[] Password { get; set; }
        public int IdEmployee { get; set; }
        public Employee Employee { get; set; }
        public bool Status { get; set; }

        public class Map
        {
            public Map(EntityTypeBuilder<User> ebUser)
            {
                ebUser.HasKey(x => x.IdUser);
                ebUser.Property(x => x.UserName).HasColumnName("UserName").HasMaxLength(50);
                ebUser.Property(x => x.Salt).HasColumnName("Salt").HasColumnType("varbinary(MAX)");
                ebUser.Property(x => x.Password).HasColumnName("Password").HasColumnType("varbinary(MAX)");
                ebUser.Property(x => x.IdEmployee).HasColumnName("IdEmployee").HasColumnType("int");
                ebUser.Property(x => x.Status).HasColumnName("Status").HasColumnType("bit");
                ebUser.HasOne(x => x.Employee);
            }
        }
    }
}
