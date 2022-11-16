namespace Discourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedPostTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.String(nullable: false),
                    Title = c.String(nullable: false),
                    Body = c.String(nullable: false),
                    TimeStamp = c.DateTime(nullable: false),
                    FirstName = c.String(nullable: false),
                    LastName = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
