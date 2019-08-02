using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class TeamCellInicializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TeamCellContext>
    {
        protected override void Seed(TeamCellContext context)
        {
            //aqui se hacen las inserciones, cuando se crea la BD
        }
    }
}
