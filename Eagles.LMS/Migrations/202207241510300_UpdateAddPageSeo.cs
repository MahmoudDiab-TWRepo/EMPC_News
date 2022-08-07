namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAddPageSeo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Citizens", "SEOTitleArabic", c => c.String());
            AddColumn("dbo.Citizens", "SEOTitleEnglish", c => c.String());
            AddColumn("dbo.Citizens", "SEOMetaDescriptionArabic", c => c.String());
            AddColumn("dbo.Citizens", "SEOMetaDescriptionEnglish", c => c.String());
            AddColumn("dbo.Citizens", "SEOMetaKeywordsArabic", c => c.String());
            AddColumn("dbo.Citizens", "SEOMetaKeywordsEnglish", c => c.String());
            AddColumn("dbo.Citizens", "SEOCanonicalUrl", c => c.String());
            AddColumn("dbo.Locations", "SEOTitleArabic", c => c.String());
            AddColumn("dbo.Locations", "SEOTitleEnglish", c => c.String());
            AddColumn("dbo.Locations", "SEOMetaDescriptionArabic", c => c.String());
            AddColumn("dbo.Locations", "SEOMetaDescriptionEnglish", c => c.String());
            AddColumn("dbo.Locations", "SEOMetaKeywordsArabic", c => c.String());
            AddColumn("dbo.Locations", "SEOMetaKeywordsEnglish", c => c.String());
            AddColumn("dbo.Locations", "SEOCanonicalUrl", c => c.String());
            AddColumn("dbo.News", "SEOTitleArabic", c => c.String());
            AddColumn("dbo.News", "SEOTitleEnglish", c => c.String());
            AddColumn("dbo.News", "SEOMetaDescriptionArabic", c => c.String());
            AddColumn("dbo.News", "SEOMetaDescriptionEnglish", c => c.String());
            AddColumn("dbo.News", "SEOMetaKeywordsArabic", c => c.String());
            AddColumn("dbo.News", "SEOMetaKeywordsEnglish", c => c.String());
            AddColumn("dbo.News", "SEOCanonicalUrl", c => c.String());
            AddColumn("dbo.Services", "SEOTitleArabic", c => c.String());
            AddColumn("dbo.Services", "SEOTitleEnglish", c => c.String());
            AddColumn("dbo.Services", "SEOMetaDescriptionArabic", c => c.String());
            AddColumn("dbo.Services", "SEOMetaDescriptionEnglish", c => c.String());
            AddColumn("dbo.Services", "SEOMetaKeywordsArabic", c => c.String());
            AddColumn("dbo.Services", "SEOMetaKeywordsEnglish", c => c.String());
            AddColumn("dbo.Services", "SEOCanonicalUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "SEOCanonicalUrl");
            DropColumn("dbo.Services", "SEOMetaKeywordsEnglish");
            DropColumn("dbo.Services", "SEOMetaKeywordsArabic");
            DropColumn("dbo.Services", "SEOMetaDescriptionEnglish");
            DropColumn("dbo.Services", "SEOMetaDescriptionArabic");
            DropColumn("dbo.Services", "SEOTitleEnglish");
            DropColumn("dbo.Services", "SEOTitleArabic");
            DropColumn("dbo.News", "SEOCanonicalUrl");
            DropColumn("dbo.News", "SEOMetaKeywordsEnglish");
            DropColumn("dbo.News", "SEOMetaKeywordsArabic");
            DropColumn("dbo.News", "SEOMetaDescriptionEnglish");
            DropColumn("dbo.News", "SEOMetaDescriptionArabic");
            DropColumn("dbo.News", "SEOTitleEnglish");
            DropColumn("dbo.News", "SEOTitleArabic");
            DropColumn("dbo.Locations", "SEOCanonicalUrl");
            DropColumn("dbo.Locations", "SEOMetaKeywordsEnglish");
            DropColumn("dbo.Locations", "SEOMetaKeywordsArabic");
            DropColumn("dbo.Locations", "SEOMetaDescriptionEnglish");
            DropColumn("dbo.Locations", "SEOMetaDescriptionArabic");
            DropColumn("dbo.Locations", "SEOTitleEnglish");
            DropColumn("dbo.Locations", "SEOTitleArabic");
            DropColumn("dbo.Citizens", "SEOCanonicalUrl");
            DropColumn("dbo.Citizens", "SEOMetaKeywordsEnglish");
            DropColumn("dbo.Citizens", "SEOMetaKeywordsArabic");
            DropColumn("dbo.Citizens", "SEOMetaDescriptionEnglish");
            DropColumn("dbo.Citizens", "SEOMetaDescriptionArabic");
            DropColumn("dbo.Citizens", "SEOTitleEnglish");
            DropColumn("dbo.Citizens", "SEOTitleArabic");
        }
    }
}
