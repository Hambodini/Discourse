namespace Discourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNamesToCommentDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "FirstName", c => c.String());
            AddColumn("dbo.Comments", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "LastName");
            DropColumn("dbo.Comments", "FirstName");
        }
    }
}
