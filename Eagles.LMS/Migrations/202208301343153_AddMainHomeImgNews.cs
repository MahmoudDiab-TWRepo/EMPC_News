namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMainHomeImgNews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "MainHomeImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "MainHomeImage");
        }
    }
}
