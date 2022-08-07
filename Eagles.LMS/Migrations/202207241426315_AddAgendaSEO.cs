namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgendaSEO : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agenda", "SEOTitleArabic", c => c.String());
            AddColumn("dbo.Agenda", "SEOTitleEnglish", c => c.String());
            AddColumn("dbo.Agenda", "SEOMetaDescriptionArabic", c => c.String());
            AddColumn("dbo.Agenda", "SEOMetaDescriptionEnglish", c => c.String());
            AddColumn("dbo.Agenda", "SEOMetaKeywordsArabic", c => c.String());
            AddColumn("dbo.Agenda", "SEOMetaKeywordsEnglish", c => c.String());
            AddColumn("dbo.Agenda", "SEOCanonicalUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Agenda", "SEOCanonicalUrl");
            DropColumn("dbo.Agenda", "SEOMetaKeywordsEnglish");
            DropColumn("dbo.Agenda", "SEOMetaKeywordsArabic");
            DropColumn("dbo.Agenda", "SEOMetaDescriptionEnglish");
            DropColumn("dbo.Agenda", "SEOMetaDescriptionArabic");
            DropColumn("dbo.Agenda", "SEOTitleEnglish");
            DropColumn("dbo.Agenda", "SEOTitleArabic");
        }
    }
}
