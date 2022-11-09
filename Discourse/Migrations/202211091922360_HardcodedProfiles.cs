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
INSERT INTO [dbo].[Profiles] ([Id], [UserId], [Status], [Bio], [ProfilePicUrl], [BannerPicUrl]) VALUES (10, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', NULL, N'1 Bilion dollars!!!', N'/wwwroot/ProfilePic/091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312.jpg', N'/wwwroot/BannerPic/091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312.jpg')
INSERT INTO [dbo].[Profiles] ([Id], [UserId], [Status], [Bio], [ProfilePicUrl], [BannerPicUrl]) VALUES (14, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', NULL, N'1 ring 2 rule them all.', N'/wwwroot/ProfilePic/9d2cc936-18c2-41ac-829e-cd7948b30cb6.jpg', N'/wwwroot/BannerPic/9d2cc936-18c2-41ac-829e-cd7948b30cb6.jpg')
INSERT INTO [dbo].[Profiles] ([Id], [UserId], [Status], [Bio], [ProfilePicUrl], [BannerPicUrl]) VALUES (16, N'52f892e9-8692-49f2-9c68-585741c10dd3', NULL, N'vegan, non-organic, whole food hero', N'/wwwroot/ProfilePic/52f892e9-8692-49f2-9c68-585741c10dd3.jpg', N'/wwwroot/BannerPic/52f892e9-8692-49f2-9c68-585741c10dd3.jpg')
INSERT INTO [dbo].[Profiles] ([Id], [UserId], [Status], [Bio], [ProfilePicUrl], [BannerPicUrl]) VALUES (17, N'febc5f91-9747-4a3c-b38d-606484008719', NULL, N'Buy it, use it, break it, fix it, trash it, change it, mail, upgrade it, Charge it, point it, zoom it, press it, snap it, work it, quick erase it, Write it, cut it, paste it, save it, load it, check it, quick rewrite it, Plug it, play it, burn it, rip it, rip it', N'/wwwroot/ProfilePic/febc5f91-9747-4a3c-b38d-606484008719.jpg', N'/wwwroot/BannerPic/febc5f91-9747-4a3c-b38d-606484008719.jpg')
SET IDENTITY_INSERT [dbo].[Profiles] OFF

");
        }
        
        public override void Down()
        {
        }
    }
}
