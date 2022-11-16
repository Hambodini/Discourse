namespace Discourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNamesToPostsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "FirstName", c => c.String());
            AddColumn("dbo.Posts", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "LastName");
            DropColumn("dbo.Posts", "FirstName");
        }
    }
}
