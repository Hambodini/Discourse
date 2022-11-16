namespace Discourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seededPosts : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                SET IDENTITY_INSERT [dbo].[Posts] ON
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (4, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'Daft Punk is pretty cool', N'With an unmatched talent for sampling, pitch-perfect production and hard funk grooves, Daft Punk will undeniably be regarded as the most influential artists of all time. Daft Punk may arguably be famous for their chromatic robot helmets, which disguised the pair''s identity', N'2022-11-04 01:22:13', N'admin', N'admin')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (5, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'Why gummy bears after a workout?', N'Research has shown that high-glycemic, or fast-acting, carbs are best right after a workout. Bodybuilders prefer gummy bears because of the kind of sugars they contain, like dextrose and high fructose corn syrup. These carbs are quickly absorbed by their bodies because they do not have to be digested to be absorbed.', N'2022-11-04 01:23:07', N'admin', N'admin')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (6, N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'How many darkest dungeons are there?', N'The Darkest Dungeon contains 4 quests in total, all of which are Darkest level and all of which are required to complete the game. Although it is unlocked early, an inexperienced team has little hope for victory there.', N'2022-11-04 01:24:20', N'admin', N'admin')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (7, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'360 no-scope', N'A dumb move often performed by people too bored with a first-person shooter wherein a player using a sniper rifle fires and kills a target, without zooming in, while turning around as fast as humanly possible. i totally owned that noob with a 360 no-scope. oh wait, that wasn''t ownage, that move is pure luck.', N'2022-11-04 01:27:32', N'Bilbo', N'TBaggins')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (11, N'52f892e9-8692-49f2-9c68-585741c10dd3', N'Slow Down, You''re Losing Me. (Halo: Combat Evolved)', N'Unlike many game protagonists, Master Chief never pretends to be a strong thinker. When Cortana realizes that the Halo rings are more dangerous than Chief believes them to be, she tries to explain what''s going on and what will happen if he fires the rings off. Without missing a beat, Chief unashamedly admits that she''s throwing out too much information, and he can''t keep up. Cortana doesn''t scold him but instead accepts his strengths and weaknesses and explains the situation in a way that convinces him to make the right decision.', N'2022-11-04 01:34:28', N'Master', N'Beef')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (12, N'52f892e9-8692-49f2-9c68-585741c10dd3', N'Wake Me When You Need Me. (Halo 3)', N'The Halo franchise didn''t end with Halo 3. In fact, Master Chief''s third outing wasn''t even Bungie''s last entry in the Halo universe. That being said, the beloved Halo 3 is arguably the best campaign in the franchise and felt very much like the end of an era for both players and the studio. After Master Chief uses the arc to stop the flood and ensure humanity survives, he is left drifting in space with his AI companion. Master Chief may say this line to Cortana, but players knew that he was talking to them, too. Though two more Halo games were released shortly after Halo 3, it was five years before Master Chief retook center stage in 343''s Halo 4.', N'2022-11-04 01:36:34', N'Master', N'Beef')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (14, N'febc5f91-9747-4a3c-b38d-606484008719', N'Technologic About', N'Technologic is the second single from Daft Punk''s third studio album Human After All. It appears as track 9, following Television Rules the Nation and preceding Emotion.', N'2022-11-04 01:40:01', N'Techno', N'Logic')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (15, N'febc5f91-9747-4a3c-b38d-606484008719', N'Ghost Ship (2002 film)', N'Ghost Ship is a 2002 American supernatural horror film directed by Steve Beck, and starring an ensemble cast featuring Gabriel Byrne, Julianna Margulies, Ron Eldard, Desmond Harrington, Isaiah Washington and Karl Urban. The film follows a marine salvage crew in the Bering Sea who discover a mysterious ocean liner that disappeared in 1962.', N'2022-11-04 01:41:27', N'Techno', N'Logic')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (16, N'febc5f91-9747-4a3c-b38d-606484008719', N'Robot', N'A robot is a machine�especially one programmable by a computer�capable of carrying out a complex series of actions automatically.[2] A robot can be guided by an external control device, or the control may be embedded within. Robots may be constructed to evoke human form, but most robots are task-performing machines, designed with an emphasis on stark functionality, rather than expressive aesthetics.', N'2022-11-04 01:42:35', N'Techno', N'Logic')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (17, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'history of lord of the rings', N'The History of The Lord of the Rings is a four-volume work by Christopher Tolkien published between 1988 and 1992 that documents the process of J. R. R. Tolkien''s writing of The Lord of the Rings', N'2022-11-09 13:43:24', N'Bilbo', N'TBaggins')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (18, N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'The One Ring to Rule Them All For Men & Women, Lotr Ring Lord of The Rings, Hobbit Stainless Steel Rings of Power', N'The Ring of Power : The lord of the rings shows your love for the series and is a power symbol. The ring has a ''one ring to rule them all'' inscription that you can show off to your friends and other Lord of the Rings fans.', N'2022-11-09 13:45:57', N'Bilbo', N'TBaggins')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [TimeStamp], [FirstName], [LastName]) VALUES (19, N'52f892e9-8692-49f2-9c68-585741c10dd3', N'2 AMAZING FACTS ABOUT COWS THAT WILL IMPRESS YOUR FRIENDS', N' All �cows� are female. Males are called bulls or steer. Before having a calf for the very first time, a female is called heifer. Then, once she has her first calf, she becomes a cow. There are over 800 different cattle breeds recognized worldwide (according to Wikipedia). For example, beef breeds are raised for their meat, and dairy breeds are raised to produce milk. At Clover Meadows Beef, we raise Angus-based cattle, which is a beef breed.', N'2022-11-09 13:47:57', N'Master', N'Beef')
                SET IDENTITY_INSERT [dbo].[Posts] OFF
            ");
        }
        
        public override void Down()
        {
        }
    }
}
