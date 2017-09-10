namespace SkinsHive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'86be8979-36b9-4fb1-985f-b049a3b2b8f2', N'guest@skinshive.com', 0, N'AEJUUJBNAMnzVKh2rdrl6EanHx/NDQJ9vdQedBgXRBwgU8v0hRRN9rQh+K80q/lI6w==', N'bcaf7f87-7eb2-4c1a-8669-437295fcc7c0', NULL, 0, 0, NULL, 1, 0, N'guest@skinshive.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd2125e71-9f19-4823-8ab6-06ca184c2da9', N'admin@skinshive.com', 0, N'AHZtrebN6590LyvDLh0LPD0g/6WXZjBlYGvEeVy8H2nifrxrK0TEwY8PwGG+czXuEA==', N'7db192c5-5d42-4e4e-b7df-d76225713f7f', NULL, 0, 0, NULL, 1, 0, N'admin@skinshive.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f5a51931-56c0-4c19-b042-0af4f432739c', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd2125e71-9f19-4823-8ab6-06ca184c2da9', N'f5a51931-56c0-4c19-b042-0af4f432739c')

");
        }
        
        public override void Down()
        {
        }
    }
}
