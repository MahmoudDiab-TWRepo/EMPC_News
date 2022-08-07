﻿namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sepicial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SEO", "Specials", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SEO", "Specials");
        }
    }
}