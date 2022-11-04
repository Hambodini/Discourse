namespace Discourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HardcodedFriends : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Friends] ON
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (1, N'febc5f91-9747-4a3c-b38d-606484008719', N'9d2cc936-18c2-41ac-829e-cd7948b30cb6')
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (2, N'febc5f91-9747-4a3c-b38d-606484008719', N'52f892e9-8692-49f2-9c68-585741c10dd3')
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (3, N'52f892e9-8692-49f2-9c68-585741c10dd3', N'febc5f91-9747-4a3c-b38d-606484008719')
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (4, N'52f892e9-8692-49f2-9c68-585741c10dd3', N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312')
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (5, N'52f892e9-8692-49f2-9c68-585741c10dd3', N'52f892e9-8692-49f2-9c68-585741c10dd3')
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (6, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312')
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (7, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'52f892e9-8692-49f2-9c68-585741c10dd3')
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (8, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'9d2cc936-18c2-41ac-829e-cd7948b30cb6')
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (9, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'52f892e9-8692-49f2-9c68-585741c10dd3')
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (10, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'9d2cc936-18c2-41ac-829e-cd7948b30cb6')
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (11, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'febc5f91-9747-4a3c-b38d-606484008719')
INSERT INTO [dbo].[Friends] ([Id], [UserId], [FriendUsersId]) VALUES (12, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312')
SET IDENTITY_INSERT [dbo].[Friends] OFF

");
        }
        
        public override void Down()
        {
        }
    }
}
