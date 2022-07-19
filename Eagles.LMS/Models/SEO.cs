using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eagles.LMS.Models
{
    [Table("SEO")]
    public class SEO
    {
        public int Id { get; set; }

        [AllowHtml]
        public string GoogleTageManager { get; set; }
        [AllowHtml]
        public string GoogleTageAnalitics { get; set; }
        [AllowHtml]
        public string GoogleTageSearch { get; set; }


        public string HomePageTitleArabic { get; set; }
        public string HomePageTitleEnglish { get; set; }
        public string HomPageMetaDescriptionArabic { get; set; }
        public string HomPageMetaDescriptionEnglish { get; set; }
        public string HomPageMetaKeywordsArabic { get; set; }
        public string HomPageMetaKeywordsEnglish { get; set; }
        public string HomPageCanonicalUrl { get; set; }




        public string AboutUsPageTitleArabic { get; set; }
        public string AboutUsPageTitleEnglish { get; set; }
        public string AboutUsPageMetaDescriptionArabic { get; set; }
        public string AboutUsPageMetaDescriptionEnglish { get; set; }
        public string AboutUsPageMetaKeywordsArabic { get; set; }
        public string AboutUsPageMetaKeywordsEnglish { get; set; }
        public string AboutUsPageCanonicalUrl { get; set; }




        public string OutDoorLocationsPageTitleArabic { get; set; }
        public string OutDoorLocationsPageTitleEnglish { get; set; }
        public string OutDoorLocationsPageMetaDescriptionArabic { get; set; }
        public string OutDoorLocationsPageMetaDescriptionEnglish { get; set; }
        public string OutDoorLocationsPageMetaKeywordsArabic { get; set; }
        public string OutDoorLocationsPageMetaKeywordsEnglish { get; set; }
        public string OutDoorLocationsPageCanonicalUrl { get; set; }



        public string LocationsPageTitleArabic { get; set; }
        public string LocationsPageTitleEnglish { get; set; }
        public string LocationsPageMetaDescriptionArabic { get; set; }
        public string LocationsPageMetaDescriptionEnglish { get; set; }
        public string LocationsPageMetaKeywordsArabic { get; set; }
        public string LocationsPageMetaKeywordsEnglish { get; set; }
        public string LocationsPageCanonicalUrl { get; set; }



        public string ServicesPageTitleArabic { get; set; }
        public string ServicesPageTitleEnglish { get; set; }
        public string ServicesPageMetaDescriptionArabic { get; set; }
        public string ServicesPageMetaDescriptionEnglish { get; set; }
        public string ServicesPageMetaKeywordsArabic { get; set; }
        public string ServicesPageMetaKeywordsEnglish { get; set; }
        public string ServicesPageCanonicalUrl { get; set; }



        public string NewsPageTitleArabic { get; set; }
        public string NewsPageTitleEnglish { get; set; }
        public string NewsPageMetaDescriptionArabic { get; set; }
        public string NewsPageMetaDescriptionEnglish { get; set; }
        public string NewsPageMetaKeywordsArabic { get; set; }
        public string NewsPageMetaKeywordsEnglish { get; set; }
        public string NewsPageCanonicalUrl { get; set; }



        public string AgendaPageTitleArabic { get; set; }
        public string AgendaPageTitleEnglish { get; set; }
        public string AgendaPageMetaDescriptionArabic { get; set; }
        public string AgendaPageMetaDescriptionEnglish { get; set; }
        public string AgendaPageMetaKeywordsArabic { get; set; }
        public string AgendaPageMetaKeywordsEnglish { get; set; }
        public string AgendaPageCanonicalUrl { get; set; }



        public string AlbumsPageTitleArabic { get; set; }
        public string AlbumsPageTitleEnglish { get; set; }
        public string AlbumsPageMetaDescriptionArabic { get; set; }
        public string AlbumsPageMetaDescriptionEnglish { get; set; }
        public string AlbumsPageMetaKeywordsArabic { get; set; }
        public string AlbumsPageMetaKeywordsEnglish { get; set; }
        public string AlbumsPageCanonicalUrl { get; set; }


        public string VideoPageTitleArabic { get; set; }
        public string VideoPageTitleEnglish { get; set; }
        public string VideoPageMetaDescriptionArabic { get; set; }
        public string VideoPageMetaDescriptionEnglish { get; set; }
        public string VideoPageMetaKeywordsArabic { get; set; }
        public string VideoPageMetaKeywordsEnglish { get; set; }
        public string VideoPageCanonicalUrl { get; set; }



        public string PicturePageTitleArabic { get; set; }
        public string PicturePageTitleEnglish { get; set; }
        public string PicturePageMetaDescriptionArabic { get; set; }
        public string PicturePageMetaDescriptionEnglish { get; set; }
        public string PicturePageMetaKeywordsArabic { get; set; }
        public string PicturePageMetaKeywordsEnglish { get; set; }
        public string PicturePageCanonicalUrl { get; set; }



        public string CitizenPageTitleArabic { get; set; }
        public string CitizenPageTitleEnglish { get; set; }
        public string CitizenPageMetaDescriptionArabic { get; set; }
        public string CitizenPageMetaDescriptionEnglish { get; set; }
        public string CitizenPageMetaKeywordsArabic { get; set; }
        public string CitizenPageMetaKeywordsEnglish { get; set; }
        public string CitizenPageCanonicalUrl { get; set; }



        public string ContactUsPageTitleArabic { get; set; }
        public string ContactUsPageTitleEnglish { get; set; }
        public string ContactUsPageMetaDescriptionArabic { get; set; }
        public string ContactUsPageMetaDescriptionEnglish { get; set; }
        public string ContactUsPageMetaKeywordsArabic { get; set; }
        public string ContactUsPageMetaKeywordsEnglish { get; set; }
        public string ContactUsPageCanonicalUrl { get; set; }


        public string CareersPageTitleArabic { get; set; }
        public string CareersPageTitleEnglish { get; set; }
        public string CareersPageMetaDescriptionArabic { get; set; }
        public string CareersPageMetaDescriptionEnglish { get; set; }
        public string CareersPageMetaKeywordsArabic { get; set; }
        public string CareersPageMetaKeywordsEnglish { get; set; }
        public string CareersPageCanonicalUrl { get; set; }






        public int UserEditId { get; set; }
        public DateTime EditeTime { get; set; }
    }
}