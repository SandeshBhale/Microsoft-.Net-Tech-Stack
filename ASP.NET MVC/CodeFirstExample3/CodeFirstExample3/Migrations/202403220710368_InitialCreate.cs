namespace CodeFirstExample3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Depts",
                c => new
                    {
                        DeptId = c.Long(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.Long(nullable: false, identity: true),
                        EmpName = c.String(),
                        EmpSal = c.String(),
                        Mob = c.String(),
                        DeptId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.EmpId)
                .ForeignKey("dbo.Depts", t => t.DeptId, cascadeDelete: true)
                .Index(t => t.DeptId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DeptId", "dbo.Depts");
            DropIndex("dbo.Employees", new[] { "DeptId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Depts");
        }
    }
}
