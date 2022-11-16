namespace Discourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createReportedPostsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReportedPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReporterUserId = c.String(nullable: false),
                        Reason = c.String(),
                        DateReported = c.DateTime(nullable: false),
                        ReportedUserId = c.String(nullable: false),
                        PostId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        Body = c.String(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReportedPosts");
        }
    }
}
