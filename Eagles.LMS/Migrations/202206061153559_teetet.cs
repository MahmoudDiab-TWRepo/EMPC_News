namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teetet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "LoginDate", c => c.DateTime());
            AddColumn("dbo.Users", "LogoutDate", c => c.DateTime());
            AddColumn("dbo.logs", "LoginDate", c => c.DateTime());
            AddColumn("dbo.logs", "LogoutDate", c => c.DateTime());
            AddColumn("dbo.logs", "ActionTitle", c => c.String());
            AlterColumn("dbo.AboutUs", "TitleArabic", c => c.String());
            AlterColumn("dbo.AboutUs", "TitleEnglish", c => c.String());
            AlterColumn("dbo.AboutUs", "DescriptionArabic", c => c.String());
            AlterColumn("dbo.AboutUs", "DescriptionEnglish", c => c.String());
            AlterColumn("dbo.AboutUs", "HomeTapDescriptionArabic", c => c.String());
            AlterColumn("dbo.AboutUs", "HomeTapDescriptionEnglish", c => c.String());
            AlterColumn("dbo.AboutUs", "ProfileDescriptionArabic", c => c.String());
            AlterColumn("dbo.AboutUs", "ProfileDescriptionEnglish", c => c.String());
            AlterColumn("dbo.AboutUs", "MessageTapDescriptionArabic", c => c.String());
            AlterColumn("dbo.AboutUs", "MessageTapDescriptionEnglish", c => c.String());
            AlterColumn("dbo.Agenda", "TitleArabic", c => c.String());
            AlterColumn("dbo.Agenda", "TitleEnglish", c => c.String());
            AlterColumn("dbo.Agenda", "DescriptionArabic", c => c.String());
            AlterColumn("dbo.Agenda", "DescriptionEnglish", c => c.String());
            AlterColumn("dbo.Agenda", "ShortDescriptionArabic", c => c.String());
            AlterColumn("dbo.Agenda", "ShortDescriptionEnglish", c => c.String());
            AlterColumn("dbo.Albums", "TitleArabic", c => c.String());
            AlterColumn("dbo.Albums", "TitleEnglish", c => c.String());
            AlterColumn("dbo.Citizens", "TitleEnglish", c => c.String());
            AlterColumn("dbo.Citizens", "DescriptionArabic", c => c.String());
            AlterColumn("dbo.Citizens", "DescriptionEnglish", c => c.String());
            AlterColumn("dbo.Clients", "NameArabic", c => c.String());
            AlterColumn("dbo.Clients", "NameEnglish", c => c.String());
            AlterColumn("dbo.ContactUs", "AddressArabic", c => c.String());
            AlterColumn("dbo.ContactUs", "AddressEnglish", c => c.String());
            AlterColumn("dbo.ContactUs", "CompanyTitleArabic", c => c.String());
            AlterColumn("dbo.ContactUs", "CompanyTitleEnglish", c => c.String());
            AlterColumn("dbo.Locations", "TitleArabic", c => c.String());
            AlterColumn("dbo.Locations", "TitleEnglish", c => c.String());
            AlterColumn("dbo.Locations", "DescriptionArabic", c => c.String());
            AlterColumn("dbo.Locations", "DescriptionEnglish", c => c.String());
            AlterColumn("dbo.Locations", "ShortDescriptionArabic", c => c.String());
            AlterColumn("dbo.Locations", "ShortDescriptionEnglish", c => c.String());
            AlterColumn("dbo.News", "TitleArabic", c => c.String());
            AlterColumn("dbo.News", "TitleEnglish", c => c.String());
            AlterColumn("dbo.News", "DescriptionArabic", c => c.String());
            AlterColumn("dbo.News", "DescriptionEnglish", c => c.String());
            AlterColumn("dbo.News", "ShortDescriptionArabic", c => c.String());
            AlterColumn("dbo.News", "ShortDescriptionEnglish", c => c.String());
            AlterColumn("dbo.RelatedWebSites", "TitleArabic", c => c.String());
            AlterColumn("dbo.RelatedWebSites", "TitleEnglish", c => c.String());
            AlterColumn("dbo.RelatedWebSites", "DescriptionArabic", c => c.String());
            AlterColumn("dbo.RelatedWebSites", "DescriptionEnglish", c => c.String());
            AlterColumn("dbo.Services", "TitleArabic", c => c.String());
            AlterColumn("dbo.Services", "TitleEnglish", c => c.String());
            AlterColumn("dbo.Services", "DescriptionArabic", c => c.String());
            AlterColumn("dbo.Services", "DescriptionEnglish", c => c.String());
            AlterColumn("dbo.Services", "ShortDescriptionArabic", c => c.String());
            AlterColumn("dbo.Services", "ShortDescriptionEnglish", c => c.String());
            AlterColumn("dbo.Teams", "NameArabic", c => c.String());
            AlterColumn("dbo.Teams", "NameEnglish", c => c.String());
            AlterColumn("dbo.Teams", "JobTitleArabic", c => c.String());
            AlterColumn("dbo.Teams", "JobTitleEnglish", c => c.String());
            AlterColumn("dbo.Teams", "JobDescriptionArabic", c => c.String());
            AlterColumn("dbo.Teams", "JobDescriptionEnglish", c => c.String());
            DropColumn("dbo.Locations", "Type");
            DropTable("dbo.Applications");
            DropTable("dbo.Brochures");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Brochures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DescriptionArabic = c.String(nullable: false),
                        DescriptionEnglish = c.String(nullable: false),
                        PdfLink = c.String(),
                        Image = c.String(),
                        EditeTime = c.DateTime(nullable: false),
                        UserEditId = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UserCreateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TitleArabic = c.String(nullable: false),
                        TitleEnglish = c.String(nullable: false),
                        Link = c.String(nullable: false),
                        EditeTime = c.DateTime(nullable: false),
                        UserEditId = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UserCreateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Locations", "Type", c => c.String());
            AlterColumn("dbo.Teams", "JobDescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Teams", "JobDescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Teams", "JobTitleEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Teams", "JobTitleArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Teams", "NameEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Teams", "NameArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "ShortDescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "ShortDescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "DescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "DescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "TitleEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "TitleArabic", c => c.String(nullable: false));
            AlterColumn("dbo.RelatedWebSites", "DescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.RelatedWebSites", "DescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.RelatedWebSites", "TitleEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.RelatedWebSites", "TitleArabic", c => c.String(nullable: false));
            AlterColumn("dbo.News", "ShortDescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.News", "ShortDescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.News", "DescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.News", "DescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.News", "TitleEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.News", "TitleArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "ShortDescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "ShortDescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "DescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "DescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "TitleEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "TitleArabic", c => c.String(nullable: false));
            AlterColumn("dbo.ContactUs", "CompanyTitleEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.ContactUs", "CompanyTitleArabic", c => c.String(nullable: false));
            AlterColumn("dbo.ContactUs", "AddressEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.ContactUs", "AddressArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "NameEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "NameArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Citizens", "DescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Citizens", "DescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Citizens", "TitleEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Albums", "TitleEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Albums", "TitleArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Agenda", "ShortDescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Agenda", "ShortDescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Agenda", "DescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Agenda", "DescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.Agenda", "TitleEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.Agenda", "TitleArabic", c => c.String(nullable: false));
            AlterColumn("dbo.AboutUs", "MessageTapDescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.AboutUs", "MessageTapDescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.AboutUs", "ProfileDescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.AboutUs", "ProfileDescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.AboutUs", "HomeTapDescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.AboutUs", "HomeTapDescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.AboutUs", "DescriptionEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.AboutUs", "DescriptionArabic", c => c.String(nullable: false));
            AlterColumn("dbo.AboutUs", "TitleEnglish", c => c.String(nullable: false));
            AlterColumn("dbo.AboutUs", "TitleArabic", c => c.String(nullable: false));
            DropColumn("dbo.logs", "ActionTitle");
            DropColumn("dbo.logs", "LogoutDate");
            DropColumn("dbo.logs", "LoginDate");
            DropColumn("dbo.Users", "LogoutDate");
            DropColumn("dbo.Users", "LoginDate");
        }
    }
}
