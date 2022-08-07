namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDSEOGALLSRY : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "SEOTitleArabic", c => c.String());
            AddColumn("dbo.Albums", "SEOTitleEnglish", c => c.String());
            AddColumn("dbo.Albums", "SEOMetaDescriptionArabic", c => c.String());
            AddColumn("dbo.Albums", "SEOMetaDescriptionEnglish", c => c.String());
            AddColumn("dbo.Albums", "SEOMetaKeywordsArabic", c => c.String());
            AddColumn("dbo.Albums", "SEOMetaKeywordsEnglish", c => c.String());
            AddColumn("dbo.Albums", "SEOCanonicalUrl", c => c.String());
            AddColumn("dbo.Galaries", "SEOTitleArabic", c => c.String());
            AddColumn("dbo.Galaries", "SEOTitleEnglish", c => c.String());
            AddColumn("dbo.Galaries", "SEOMetaDescriptionArabic", c => c.String());
            AddColumn("dbo.Galaries", "SEOMetaDescriptionEnglish", c => c.String());
            AddColumn("dbo.Galaries", "SEOMetaKeywordsArabic", c => c.String());
            AddColumn("dbo.Galaries", "SEOMetaKeywordsEnglish", c => c.String());
            AddColumn("dbo.Galaries", "SEOCanonicalUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Galaries", "SEOCanonicalUrl");
            DropColumn("dbo.Galaries", "SEOMetaKeywordsEnglish");
            DropColumn("dbo.Galaries", "SEOMetaKeywordsArabic");
            DropColumn("dbo.Galaries", "SEOMetaDescriptionEnglish");
            DropColumn("dbo.Galaries", "SEOMetaDescriptionArabic");
            DropColumn("dbo.Galaries", "SEOTitleEnglish");
            DropColumn("dbo.Galaries", "SEOTitleArabic");
            DropColumn("dbo.Albums", "SEOCanonicalUrl");
            DropColumn("dbo.Albums", "SEOMetaKeywordsEnglish");
            DropColumn("dbo.Albums", "SEOMetaKeywordsArabic");
            DropColumn("dbo.Albums", "SEOMetaDescriptionEnglish");
            DropColumn("dbo.Albums", "SEOMetaDescriptionArabic");
            DropColumn("dbo.Albums", "SEOTitleEnglish");
            DropColumn("dbo.Albums", "SEOTitleArabic");
        }
    }
}
