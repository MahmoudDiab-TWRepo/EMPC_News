﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Eagles.LMS.Models
{

    [Table("ContactRequist")]

    public class ContactRequist
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Message { get; set; }

        public string CVLink { get; set; }
    }

}