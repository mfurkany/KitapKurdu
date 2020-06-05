namespace KitapKurdu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0e86d001-bccf-42d6-8dd1-4ded3bf700f3', N'guest@abc.com', 0, N'ACXIDHYEsemDC+udIn5OGoxECq3VmC1skiy0qLYsKyQTnTQTvpR0fXdpfcwuqlBI4g==', N'c5419347-ed23-434c-b218-ace8a5fb6f92', NULL, 0, 0, NULL, 1, 0, N'guest@abc.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8b0b0afa-552d-4b90-b41b-925879550150', N'admin@kitapkurdu.com', 0, N'AHgiy3XcysXEBFRLyYrhcT3f97iUynJp1EpHLmJkxgSIZUuTtrtxXseZ7wyhWsSHzA==', N'92a20164-3d90-4b5b-8651-2626aa7a1a55', NULL, 0, 0, NULL, 1, 0, N'admin@kitapkurdu.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4ad50ab4-6ade-4cb0-bc3a-1298ab48082d', N'CanManageBooks')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8b0b0afa-552d-4b90-b41b-925879550150', N'4ad50ab4-6ade-4cb0-bc3a-1298ab48082d')


");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "PhoneNumber");
        }
    }
}
