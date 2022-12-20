namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSlug : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agenda", "Slug", c => c.String());
            AddColumn("dbo.Albums", "Slug", c => c.String());
            AddColumn("dbo.Galaries", "Slug", c => c.String());
            AddColumn("dbo.Locations", "Slug", c => c.String());
            AddColumn("dbo.News", "Slug", c => c.String());
            AddColumn("dbo.Services", "Slug", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "Slug");
            DropColumn("dbo.News", "Slug");
            DropColumn("dbo.Locations", "Slug");
            DropColumn("dbo.Galaries", "Slug");
            DropColumn("dbo.Albums", "Slug");
            DropColumn("dbo.Agenda", "Slug");
        }
    }
}
