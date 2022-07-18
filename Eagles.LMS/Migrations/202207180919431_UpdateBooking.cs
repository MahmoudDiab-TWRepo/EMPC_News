namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBooking : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "LiveStudio", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bookings", "LiveStudio");
        }
    }
}
