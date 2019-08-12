namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableClient : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "RRHH.Employee", newSchema: "Client");
            CreateTable(
                "Client.Client",
                c => new
                    {
                        IdClient = c.Int(nullable: false),
                        Name = c.String(maxLength: 200),
                        CardIdentification = c.String(maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdClient);
            
            AddColumn("Client.Employee", "Status", c => c.Boolean(nullable: false));
            DropColumn("Client.Employee", "Estado");
        }
        
        public override void Down()
        {
            AddColumn("Client.Employee", "Estado", c => c.Boolean(nullable: false));
            DropColumn("Client.Employee", "Status");
            DropTable("Client.Client");
            MoveTable(name: "Client.Employee", newSchema: "RRHH");
        }
    }
}
