using Eagles.LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Eagles.LMS.BLL
{
    public class ContactRquistManager : Reposatory<ContactRequist>
    {
        public ContactRquistManager(LMS.Data.EmcNewsContext ctx) : base(ctx) { }
    }
}