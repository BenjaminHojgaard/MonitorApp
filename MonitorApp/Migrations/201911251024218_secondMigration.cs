namespace MonitorApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MonitorUsers", "DateCreated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MonitorUsers", "DateCreated", c => c.DateTime(nullable: false));
        }
    }
}
