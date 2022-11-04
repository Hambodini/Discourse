namespace Discourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminToRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'091b17e2-4dd9-4d0f-8aa0-f6f1cf4f8312', N'1')
");
        }
        
        public override void Down()
        {
        }
    }
}
