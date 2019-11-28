namespace MonitorApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPasswordToMonitorUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MonitorUsers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MonitorUsers", "Password");
        }
    }
}
