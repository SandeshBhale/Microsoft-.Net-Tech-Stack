namespace CodeFirstExample3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Mobile", c => c.String());
            DropColumn("dbo.Employees", "Mobbile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Mobbile", c => c.String());
            DropColumn("dbo.Employees", "Mobile");
        }
    }
}
