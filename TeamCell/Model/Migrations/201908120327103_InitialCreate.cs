namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "RRHH.Employee",
                c => new
                    {
                        IdEmployee = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        SecondName = c.String(maxLength: 50),
                        FirstSurname = c.String(maxLength: 50),
                        SecondSurname = c.String(maxLength: 50),
                        BirthDay = c.DateTime(nullable: false),
                        IdentificationCard = c.String(maxLength: 100),
                        State = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdEmployee);
            
        }
        
        public override void Down()
        {
            DropTable("RRHH.Employee");
        }
    }
}
