namespace Discourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HardcodedProfiles : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Profiles] ON
INSERT INTO [dbo].[Profiles] ([Id], [UserId], [Status], [Bio], [ProfilePicUrl], [BannerPicUrl]) VALUES (1, N'66b84ac3-2209-4c0f-a485-bd961c25e679', NULL, NULL, N'/wwwroot/ProfilePic/NoPic.jpg', N'/wwwroot/BannerPic/NoBanner.jpg')
INSERT INTO [dbo].[Profiles] ([Id], [UserId], [Status], [Bio], [ProfilePicUrl], [BannerPicUrl]) VALUES (2, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', NULL, NULL, N'/wwwroot/ProfilePic/NoPic.jpg', N'/wwwroot/BannerPic/NoBanner.jpg')
INSERT INTO [dbo].[Profiles] ([Id], [UserId], [Status], [Bio], [ProfilePicUrl], [BannerPicUrl]) VALUES (3, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', NULL, NULL, N'/wwwroot/ProfilePic/NoPic.jpg', N'/wwwroot/BannerPic/NoBanner.jpg')
INSERT INTO [dbo].[Profiles] ([Id], [UserId], [Status], [Bio], [ProfilePicUrl], [BannerPicUrl]) VALUES (4, N'52f892e9-8692-49f2-9c68-585741c10dd3', NULL, NULL, N'/wwwroot/ProfilePic/NoPic.jpg', N'/wwwroot/BannerPic/NoBanner.jpg')
INSERT INTO [dbo].[Profiles] ([Id], [UserId], [Status], [Bio], [ProfilePicUrl], [BannerPicUrl]) VALUES (5, N'febc5f91-9747-4a3c-b38d-606484008719', NULL, NULL, N'/wwwroot/ProfilePic/NoPic.jpg', N'/wwwroot/BannerPic/NoBanner.jpg')
SET IDENTITY_INSERT [dbo].[Profiles] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
