namespace MonitorApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetimeChangeAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MonitorUsers", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MonitorUsers", "DateCreated");
        }
    }
}
