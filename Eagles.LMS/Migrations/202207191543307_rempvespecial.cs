namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rempvespecial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SEO", "Specials");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SEO", "Specials", c => c.String());
        }
    }
}
