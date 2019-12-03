namespace MVC5Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 8000, unicode: false),
                        EmpCode = c.String(maxLength: 8000, unicode: false),
                        Position = c.String(maxLength: 8000, unicode: false),
                        OfficeLocation = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
