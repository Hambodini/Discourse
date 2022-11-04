namespace Discourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HardcodedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [BirthDate], [IsBanned]) VALUES (N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'admin@email.com', 0, N'ADsqPCyFN93HfJkq4v/hHbIFqQIXK+gXfsG8camPy6XBCKYJhljdzxrDeMojzYcpkQ==', N'a561021c-7b1e-48e9-b259-0da9d52c0050', NULL, 0, 0, NULL, 1, 0, N'admin@email.com', N'admin', N'admin', N'1999-02-25 00:00:00', 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [BirthDate], [IsBanned]) VALUES (N'52f892e9-8692-49f2-9c68-585741c10dd3', N'normal2@email.com', 0, N'AI6z5MI/zQ431NPKbMGp3Lyxv2aHduC2gFwWksuSifsZIkNuC2lhO8Mzo59mN7H3iQ==', N'89b19fd5-3186-49e0-b9db-cae3ff13cb02', NULL, 0, 0, NULL, 1, 0, N'normal2@email.com', N'Master', N'Beef', N'1999-02-25 00:00:00', 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [BirthDate], [IsBanned]) VALUES (N'9d2cc936-18c2-41ac-829e-cd7948b30cb6', N'normal1@email.com', 0, N'AOxTK2Tysw/n3eKYtI/kzuNT2CRNq1X9oyY7VkInUlKit/a7PdRNxPQ7NqblAcCXAw==', N'd00b2b9e-aced-41b4-900c-df60e4996ec1', NULL, 0, 0, NULL, 1, 0, N'normal1@email.com', N'Bilbo', N'TBaggins', N'1999-02-25 00:00:00', 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [BirthDate], [IsBanned]) VALUES (N'febc5f91-9747-4a3c-b38d-606484008719', N'normal3@email.com', 0, N'AIHVi+ma7ZlnZz0PeAal+O8QUcCLmfKki7PlLLwc5fMdExhfGN93jL30WkTRU417dA==', N'83c28aab-d754-4c93-91b4-ad2da00cf74c', NULL, 0, 0, NULL, 1, 0, N'normal3@email.com', N'Techno', N'Logic', N'1999-02-25 00:00:00', 0)

");
        }
        
        public override void Down()
        {
        }
    }
}
