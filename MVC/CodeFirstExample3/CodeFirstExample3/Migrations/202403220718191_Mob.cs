namespace CodeFirstExample3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mob : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Depts", "DeptDesc", c => c.String());
            AddColumn("dbo.Employees", "Mobbile", c => c.String());
            DropColumn("dbo.Employees", "Mob");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Mob", c => c.String());
            DropColumn("dbo.Employees", "Mobbile");
            DropColumn("dbo.Depts", "DeptDesc");
        }
    }
}
