namespace Discourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRolesTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1', N'Admin')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2', N'User')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
