namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Estado : DbMigration
    {
        public override void Up()
        {
            AddColumn("RRHH.Employee", "Estado", c => c.Boolean(nullable: false));
            DropColumn("RRHH.Employee", "Status");
        }
        
        public override void Down()
        {
            AddColumn("RRHH.Employee", "Status", c => c.Boolean(nullable: false));
            DropColumn("RRHH.Employee", "Estado");
        }
    }
}
