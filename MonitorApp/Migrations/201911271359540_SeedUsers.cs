namespace MonitorApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0cff8084-68c6-4d72-8f07-cbfa595d073e', N'MonitorAdmin@hotmail.com', 0, N'AOXunlydtNqDAuB5xlKnkM7E2B+NrpUmGIvE+WRxEtFxLkPDMTPV3GXjpWCzpnKpfA==', N'a71135e2-90ae-40b1-80fd-4c68ce73043f', NULL, 0, 0, NULL, 0, 0, N'MonitorAdmin@hotmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e900b1b6-d5f1-4155-ace8-1d8f0efcf44a', N'test3@hotmail.com', 0, N'ACgwSaiLCZgv6h/ikANFh14ohc9FGNAYqUjwbeEjF3yC567KlitAFeMNrHUEq75/Gw==', N'9a94df97-b12c-4f1e-ba5d-e8bbce859140', NULL, 0, 0, NULL, 0, 0, N'test3@hotmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'224739f8-df1b-4db4-8b3a-f181938dd898', N'CanCreateUsers')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0cff8084-68c6-4d72-8f07-cbfa595d073e', N'224739f8-df1b-4db4-8b3a-f181938dd898')

        ");
        }
        
        public override void Down()
        {
        }
    }
}
