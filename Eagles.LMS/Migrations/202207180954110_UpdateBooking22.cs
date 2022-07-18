namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBooking22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "StandUpPosition", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bookings", "TapeLayout", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bookings", "EngCrew", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bookings", "NewsPackage", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bookings", "Edite", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bookings", "Uplink", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bookings", "SataliteSpace", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bookings", "Production", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bookings", "SNG", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bookings", "OBVAN", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bookings", "Other", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bookings", "Other");
            DropColumn("dbo.Bookings", "OBVAN");
            DropColumn("dbo.Bookings", "SNG");
            DropColumn("dbo.Bookings", "Production");
            DropColumn("dbo.Bookings", "SataliteSpace");
            DropColumn("dbo.Bookings", "Uplink");
            DropColumn("dbo.Bookings", "Edite");
            DropColumn("dbo.Bookings", "NewsPackage");
            DropColumn("dbo.Bookings", "EngCrew");
            DropColumn("dbo.Bookings", "TapeLayout");
            DropColumn("dbo.Bookings", "StandUpPosition");
        }
    }
}
