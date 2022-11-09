namespace Discourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HardcodedPostsComments : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Comments] ON
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (3, 4, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'I agree', N'2022-11-04 01:22:35', N'admin', N'admin')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (4, 5, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'Idk anymore', N'2022-11-04 01:23:34', N'admin', N'admin')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (5, 6, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'My Team got wiped at the ending. f for respect.', N'2022-11-04 01:24:53', N'admin', N'admin')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (6, 7, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'i just got one believe me guys', N'2022-11-04 01:28:04', N'Bilbo', N'TBaggins')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (7, 8, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'never done it before....', N'2022-11-04 01:29:19', N'Bilbo', N'TBaggins')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (8, 7, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'it was on sauron', N'2022-11-04 01:29:41', N'Bilbo', N'TBaggins')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (9, 9, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'I had some swag but some boomers told me to toss it in a volcano to save the world or something. kinda lame.', N'2022-11-04 01:31:13', N'Bilbo', N'TBaggins')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (10, 10, N'52f892e9-8692-49f2-9c68-585741c10dd3', N'BEEEEFFFFFF', N'2022-11-04 01:33:21', N'Master', N'Beef')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (11, 11, N'52f892e9-8692-49f2-9c68-585741c10dd3', N'goes back to college: Sir, Finishing This Fight.', N'2022-11-04 01:36:02', N'Master', N'Beef')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (12, 12, N'52f892e9-8692-49f2-9c68-585741c10dd3', N'Sleeps in class: Wake Me When You Need Me.', N'2022-11-04 01:37:15', N'Master', N'Beef')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (13, 13, N'febc5f91-9747-4a3c-b38d-606484008719', N'1000 times and it is still good', N'2022-11-04 01:38:49', N'Techno', N'Logic')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (14, 14, N'febc5f91-9747-4a3c-b38d-606484008719', N'1000 times and its still good', N'2022-11-04 01:40:14', N'Techno', N'Logic')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (15, 15, N'febc5f91-9747-4a3c-b38d-606484008719', N'I love that movie', N'2022-11-04 01:41:36', N'Techno', N'Logic')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (16, 16, N'febc5f91-9747-4a3c-b38d-606484008719', N'I find this very insulting', N'2022-11-04 01:42:49', N'Techno', N'Logic')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (17, 17, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'the author was J. R. R. Tolkien', N'2022-11-09 13:44:26', N'Bilbo', N'TBaggins')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (18, 18, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'It was very easy to pour my malice, cruelty and will to dominate all life into 4/5 stars', N'2022-11-09 13:46:10', N'Bilbo', N'TBaggins')
INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (19, 19, N'52f892e9-8692-49f2-9c68-585741c10dd3', N'BBEEEEEEEEEEFFFFFFFFFFFF', N'2022-11-09 13:48:26', N'Master', N'Beef')
SET IDENTITY_INSERT [dbo].[Comments] OFF


");
        }
        
        public override void Down()
        {
        }
    }
}
