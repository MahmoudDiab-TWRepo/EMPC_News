using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eagles.LMS.Models
{
    [Table("Citizens")]
    public class Citizens
    {
        public int Id { get; set; }
        public string TitleArabic { get; set; }
        //[Required(ErrorMessage = "Title English Is Required")]


        public string TitleEnglish { get; set; }

        //[Required(ErrorMessage = "Description Arabic Is Required")]
        [AllowHtml]
        public string DescriptionArabic { get; set; }

        //[Required(ErrorMessage = "Description English Is Required")]
        [AllowHtml]
        public string DescriptionEnglish { get; set; }

        public string Image { get; set; }
        //[Required]
        //public int Order { get; set; }


        public DateTime CreateTime { get; set; }
        public int UserCreateId { get; set; }

        public DateTime EditeTime { get; set; }
        public int UserEditId { get; set; }


        public string SEOTitleArabic { get; set; }
        public string SEOTitleEnglish { get; set; }
        public string SEOMetaDescriptionArabic { get; set; }
        public string SEOMetaDescriptionEnglish { get; set; }
        public string SEOMetaKeywordsArabic { get; set; }
        public string SEOMetaKeywordsEnglish { get; set; }
        public string SEOCanonicalUrl { get; set; }

    }
}