namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateContat : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ContactUsRequist", newName: "ContactRequist");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ContactRequist", newName: "ContactUsRequist");
        }
    }
}
