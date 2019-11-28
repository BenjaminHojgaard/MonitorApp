namespace MonitorApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Country", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "UserRole", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserRole");
            DropColumn("dbo.AspNetUsers", "Country");
        }
    }
}
