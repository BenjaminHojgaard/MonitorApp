namespace MonitorApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedRoles : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MonitorUsers", "UserRole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MonitorUsers", "UserRole", c => c.Int(nullable: false));
        }
    }
}
