using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Eagles.LMS.BLL;
using Eagles.LMS.DTO;
using Eagles.LMS.Models;

using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Eagles.LMS.Helper;
using System.Web.Services.Description;
using Service = Eagles.LMS.Models.Service;
using System.Drawing.Printing;

namespace Eagles.LMS.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork ctx = new UnitOfWork();
        // GET: Home
        public ActionResult Index()
        {

            bool en = true;
            if (Request.Cookies["Language"] != null)
            {
                en = (Request.Cookies["Language"].Value.ToString() == "en") ? true : false;
            }
            if (en == true)
            {
                List<Location> LocationData = ctx.LocationManager.GetAll().Where(s => s.Status == EntityStatus.Approval && s.TitleEnglish != null).OrderByDescending(s => s.Id).ToList();
                foreach (var item in LocationData)
                {
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleEnglish);
                }
                ViewBag.LocData = LocationData;

                List<Service> ServiceData = ctx.ServiceManager.GetAll().Where(s => s.Status == EntityStatus.Approval && s.TitleEnglish != null).OrderByDescending(s => s.Id).ToList();
                foreach (var item in ServiceData)
                {
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleEnglish);
                }
                ViewBag.ServData = ServiceData;


                List<New> NewsData = ctx.NewManager.GetAll().Where(s => s.ShowInHomePage && s.Status == EntityStatus.Approval && s.TitleEnglish != null).OrderByDescending(s => s.Order).ToList();
                foreach (var item in NewsData)
                {
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleEnglish);
                }
                ViewBag.NewsData = NewsData;

                //var allPictures = ctx.GalaryManager.GetAll().Select(s => s.AlbumId).Distinct();
                //List<Album> albumsData = ctx.AlbumManager.GetAll().Where(s => allPictures.Contains(s.Id) && s.TitleEnglish != null).OrderByDescending(s => s.Id).ToList();
                //foreach (var item in albumsData)
                //{
                //    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleEnglish);
                //}
                //ViewBag.AlllBumData = albumsData;
            }
            else
            {
                List<Location> LocationData = ctx.LocationManager.GetAll().Where(s => s.Status == EntityStatus.Approval && s.TitleArabic != null).OrderByDescending(s => s.Id).ToList();
                foreach (var item in LocationData)
                {
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleArabic);
                }
                ViewBag.LocData = LocationData;

                List<Service> ServiceData = ctx.ServiceManager.GetAll().Where(s => s.Status == EntityStatus.Approval && s.TitleArabic != null).OrderByDescending(s => s.Id).ToList();
                foreach (var item in ServiceData)
                {
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleArabic);
                }
                ViewBag.ServData = ServiceData;


                List<New> NewsData = ctx.NewManager.GetAll().Where(s => s.ShowInHomePage && s.Status == EntityStatus.Approval && s.TitleArabic != null).OrderByDescending(s => s.Order).ToList();
                foreach (var item in NewsData)
                {
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleArabic);
                }
                ViewBag.NewsData = NewsData;


                //var allPictures = ctx.GalaryManager.GetAll().Select(s => s.AlbumId).Distinct();
                //List<Album> albumsData = ctx.AlbumManager.GetAll().Where(s => allPictures.Contains(s.Id) && s.TitleArabic != null).OrderByDescending(s => s.Id).ToList();
                //foreach (var item in albumsData)
                //{
                //    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleArabic);
                //}
                //ViewBag.AlllBumData = albumsData;
            }


            //return Redirect("/Admission");
            return View();
        }



        public ActionResult AboutUs()
        {
            //return Redirect("/Admission");
            return View();
        }

        public ActionResult Locations(int? id)
        {
            if (id == 0)
                return View("NotFound");
            if (id != null)
                ViewBag.Id = id;


            bool en = true;
            if (Request.Cookies["Language"] != null)
            {
                en = (Request.Cookies["Language"].Value.ToString() == "en") ? true : false;
            }
            if (en == true)
            {
                List<Location> LocationData = ctx.LocationManager.GetAll().Where(s => s.Status == EntityStatus.Approval).OrderByDescending(s => s.Id).ToList();
                foreach (var item in LocationData)
                {
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleEnglish);
                }
                ViewBag.LocData = LocationData;
                //return View(ServiceData);
            }
            else
            {
                List<Location> LocationData = ctx.LocationManager.GetAll().Where(s => s.Status == EntityStatus.Approval).OrderByDescending(s => s.Id).ToList();
                foreach (var item in LocationData)
                {
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleArabic);
                }
                ViewBag.LocData = LocationData;
                //return View(ServiceData);
            }



            //return Redirect("/Admission");
            return View();
        }

        public ActionResult LocationDetails(int? id)
        {
            if (id == null)
            {

                return View("NotFound");

            }
            if (id == 0)
                return View("NotFound");
            var loction = new Location();
            //if (loction == null)
            //{
            //    return HttpNotFound();
            //}
            bool en = true;

            if (Request.Cookies["Language"] != null)
            {
                en = (Request.Cookies["Language"].Value.ToString() == "en") ? true : false;

            }
            if (en == true)
            {
                loction = new UnitOfWork().LocationManager.GetAll().Where(s => s.TitleEnglish != null).FirstOrDefault(s => s.Id == id);
            }
            else
            {
                loction = new UnitOfWork().LocationManager.GetAll().Where(s => s.TitleArabic != null).FirstOrDefault(s => s.Id == id);
            }
            if (loction == null)
                return View("NotFound");

            loction.LocationImages = new UnitOfWork().LocationImagesManager.GetAllBind().Where(s => s.LocationId == id).ToList();
            //return Redirect("/Admission");
            return View(loction);
        }
        public ActionResult Services()
        {


            bool en = true;
            if (Request.Cookies["Language"] != null)
            {
                en = (Request.Cookies["Language"].Value.ToString() == "en") ? true : false;
            }
            if (en == true)
            {
                List<Service> ServiceData = ctx.ServiceManager.GetAll().Where(s => s.Status == EntityStatus.Approval).OrderByDescending(s => s.Id).ToList();
                foreach (var item in ServiceData)
                {
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleEnglish);

                }
                ViewBag.ServData = ServiceData;
                //return View(ServiceData);
            }
            else
            {
                List<Service> ServiceData = ctx.ServiceManager.GetAll().Where(s => s.Status == EntityStatus.Approval ).OrderByDescending(s => s.Id).ToList();
                foreach (var item in ServiceData)
                {
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleArabic);
                }
                ViewBag.ServData = ServiceData;
                //return View(ServiceData);
            }
            //return Redirect("/Admission");
            return View();
        }


        public ActionResult ServicesDetails(int? id)
        {
            if (id == null)
            {

                return View("NotFound");

            }
            if (id == 0)
                return View("NotFound");
            var service = new Service();
            //if (service == null)
            //    return HttpNotFound();
            // return Redirect("/Admission");
            bool en = true;

            if (Request.Cookies["Language"] != null)
            {
                en = (Request.Cookies["Language"].Value.ToString() == "en") ? true : false;

            }
            if (en == true)
            {
                service = new UnitOfWork().ServiceManager.GetAll().Where(s => s.TitleEnglish != null).FirstOrDefault(s => s.Id == id);
            }
            else
            {
                service = new UnitOfWork().ServiceManager.GetAll().Where(s => s.TitleArabic != null).FirstOrDefault(s => s.Id == id);
            }
            if (service == null)
                return View("NotFound");
            service.ServiceImages = new UnitOfWork().ServiceImagesManager.GetAllBind().Where(s => s.ServiceId == id).ToList();

            return View(service);
        }
        public ActionResult News()
        {
            //return Redirect("/Admission");
            return View();
        }
        public ActionResult GetNewsPageData(int pageNumber = 1, int pageSize = 9)
        {
            bool en = true;
            if (Request.Cookies["Language"] != null)
            {
                en = (Request.Cookies["Language"].Value.ToString() == "en") ? true : false;
            }
            if (en == true)
            {
                List<New> NewsData = ctx.NewManager.GetAll().Where(s => s.Status == EntityStatus.Approval ).OrderByDescending(s => s.Id).ToList();
                foreach (var item in NewsData)
                {
                    item.StringDate = item.NewsDate.ToShortDateString();
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleEnglish);
                   
                }
                var pagedData = Pagination.PagedResult(NewsData, pageNumber, pageSize);
                return Json(pagedData, JsonRequestBehavior.AllowGet);
            }
            else
            {
                List<New> NewsData = ctx.NewManager.GetAll().Where(s => s.Status == EntityStatus.Approval ).OrderByDescending(s => s.Id).ToList();
                foreach (var item in NewsData)
                {
                    item.StringDate = item.NewsDate.ToShortDateString();
                    item.TitleEnglish = item.TitleArabic;
                    item.ShortDescriptionEnglish = item.ShortDescriptionArabic;
                    item.DescriptionEnglish = item.DescriptionArabic;
                    item.Slug = Extensions.AdmissionMenue.Slugify(item.TitleArabic);
                }
                var pagedData = Pagination.PagedResult(NewsData, pageNumber, pageSize);
                return Json(pagedData, JsonRequestBehavior.AllowGet);
            }
            
        }
        public ActionResult NewsDetails(int? id)
        {
            //var _new = new UnitOfWork().NewManager.GetAll().FirstOrDefault(s => s.Id == id);
            //_new.NewImages = new UnitOfWork().NewImagesMnager.GetAllBind().Where(s => s.NewId == id).ToList();

            if (id == null)
            {
                return View("NotFound");
            }

            if (id == 0)
                return View("NotFound");


            var _new = new New();
            bool en = true;

            if (Request.Cookies["Language"] != null)
            {
                en = (Request.Cookies["Language"].Value.ToString() == "en") ? true : false;
            }
            if (en == true)
            {
                _new = new UnitOfWork().NewManager.GetAll().Where(s => s.TitleEnglish != null).FirstOrDefault(s => s.Id == id);
            }
            else
            {
                _new = new UnitOfWork().NewManager.GetAll().Where(s => s.TitleArabic != null).FirstOrDefault(s => s.Id == id);
            }
            if (_new == null)
                return View("NotFound");




            _new.NewImages = new UnitOfWork().NewImagesMnager.GetAllBind().Where(s => s.NewId == _new.Id).ToList();

            //return Redirect("/Admission");
            return View(_new);
        }
        public ActionResult Agenda(DateTime? _date)
        {
            if (_date != null)
            {
                ViewBag.Date = _date;
            }
            //return Redirect("/Admission");
            return View();
        }
        public ActionResult Albums()
        {
            return View();
        }


        public ActionResult AgendaDetails(int? id)
        {


            if (id == null)
            {

                return View("NotFound");

            }



            if (id == 0)
                return View("NotFound");
            var _agenda = new Agenda();
            //if (_agenda == null)
            //    return HttpNotFound();
            //return Redirect("/Admission");
            bool en = true;

            if (Request.Cookies["Language"] != null)
            {
                en = (Request.Cookies["Language"].Value.ToString() == "en") ? true : false;

            }
            if (en == true)
            {
                _agenda = new UnitOfWork().AgendaManager.GetAll().Where(s => s.TitleEnglish != null).FirstOrDefault(s => s.Id == id);
            }
            else
            {
                _agenda = new UnitOfWork().AgendaManager.GetAll().Where(s => s.TitleArabic != null).FirstOrDefault(s => s.Id == id);
            }
            if (_agenda == null)
                return View("NotFound");

            _agenda.AgendaImages = new UnitOfWork().AgendaImagesManager.GetAllBind().Where(s => s.AgendaId == id).ToList();
            return View(_agenda);
        }

        public ActionResult Video()
        {
            //return Redirect("/Admission");
            return View();
        }

        public ActionResult VideoAlbums()
        {
            //return Redirect("/Admission");
            return View();
        }

        //public ActionResult VideoDetails(int? id, int? albumId)
        //{
        //    if (albumId == null)
        //    {

        //        return View("NotFound");

        //    }
        //    if (albumId == 0)
        //    {

        //        return View("NotFound");

        //    }
        //    if (id == 0)
        //        return View("NotFound");

        //    if (id != null)
        //        ViewBag.Id = id;
        //    //return Redirect("/Admission");
        //    if (albumId != null)
        //        ViewBag.AlbumId = albumId;
        //    return View();
        //}

        public ActionResult VideoDetails(int? Id)
        {
            //if (id == 0)
            //    return View("NotFound");
            //if (id != null)
            //    ViewBag.Id = id;
            //if (Id != null)
              //  ViewBag.Id = Id;
            //return View();


            if (Id == null)
            {

                return View("NotFound");

            }

            if (Id == 0)
                return View("NotFound");


            var _album = new Album();
            bool en = true;

            if (Request.Cookies["Language"] != null)
            {
                en = (Request.Cookies["Language"].Value.ToString() == "en") ? true : false;

            }
            if (en == true)
            {
                _album = new UnitOfWork().AlbumManager.GetAll().Where(s => s.TitleEnglish != null).FirstOrDefault(s => s.Id == Id);

            }
            else
            {
                _album = new UnitOfWork().AlbumManager.GetAll().Where(s => s.TitleArabic != null).FirstOrDefault(s => s.Id == Id);

            }
            if (_album == null)
                return View("NotFound");




           // _new.NewImages = new UnitOfWork().NewImagesMnager.GetAllBind().Where(s => s.NewId == _new.Id).ToList();

            //return Redirect("/Admission");
            return View(_album);



        }

        public ActionResult Picture(int? id, int? albumId)
        {
            if (id == null)
            {

                return View("NotFound");

            }
            if (id == 0)
                return View("NotFound");

            if (id != null)
                ViewBag.Id = id;
            //return Redirect("/Admission");
            if (albumId != null)
                ViewBag.AlbumId = albumId;
            if (albumId == null && id == null)
                return View("NotFound");


            return View();
        }
        public ActionResult PictureDetails()
        {
            //var picture = new UnitOfWork().GalaryManager.GetBy(id);
            //if (picture == null)
            //{
            //    return HttpNotFound();mg
            //}
            //picture.Image = new UnitOfWork().GalaryManager.GetAllBind().Where(s => s.LocationId == id).ToList();
            //return Redirect("/Admission");
            return View();
        }
        public ActionResult Citizen()
        {
            //return Redirect("/Admission");
            return View();
        }
        [HttpPost]
        public ActionResult Citizen(CitizenRequist citizenRequist, HttpPostedFileBase uploadattachments)
        {

            ActionResult result = View(citizenRequist);
            string SiteDomainURL = System.Configuration.ConfigurationManager.AppSettings["SiteDomainURL"];

            if (ModelState.IsValid)
            {

                RequestStatus requestStatus;
                if (uploadattachments == null || uploadattachments.ContentLength == 0)
                {
                    requestStatus = new ManageRequestStatus().GetStatus(Status.GeneralError, "Plz Upload The Attachment");
                }
                else
                {

                    string folderName = "citizen";

                    // To create a string that specifies the path to a subfolder under your
                    // top-level folder, add a name for the subfolder to folderName.
                    string pathString = System.IO.Path.Combine(Server.MapPath("~/attachments"), folderName);
                    System.IO.Directory.CreateDirectory(pathString);
                    string extention = System.IO.Path.GetExtension(uploadattachments.FileName);
                    var fileName = Guid.NewGuid() + extention;
                    var path = Path.Combine(Server.MapPath("~/attachments/citizen"), fileName);
                    uploadattachments.SaveAs(path);
                    citizenRequist.Attachment = $"/attachments/citizen/{fileName}";

                    var ctx = new UnitOfWork();
                    ctx.CitizenRequistManager.Add(citizenRequist);

                    requestStatus = new ManageRequestStatus().GetStatus(Status.Created);

                    try
                    {
                        SendEmail sendEmail = new SendEmail();
                        sendEmail.SendMail(new EmailDTO
                        {
                            To = "To Email",
                            Message =
                            "<h1 style='font-size:25px; line-height:1.5'>New Citizen Request</h1>"
                            + "<p style='font-size:15px; color: #000'>Thank You for connecting us and we will get back to you soon.</p>"
                            + "<b style='font-size:12px; line-height:1.5'><br/><br/>First Name:</b>" + citizenRequist.FirstName + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Last Name :</b>" + citizenRequist.LastName + "<br />" +
                            "<b style='font-size:12px; line-height:1.5'>Email:</b>" + citizenRequist.Email + "<br />" +
                            "<b style='font-size:12px; line-height:1.5'>Phone Number:</b>" + citizenRequist.Phone + "<br />" +
                            "<b style='font-size:12px; line-height:1.5'>Message:</b>" + citizenRequist.Message + "<br />" +
                            "<b style='font-size:12px; line-height:1.5'>Attachment link:  </b><a href='" + SiteDomainURL + citizenRequist.Attachment + "'>" + SiteDomainURL + citizenRequist.Attachment + "</a><br />",
                            From = "web@empcnews.com",
                            Subject = "New Citizen"
                        }, "Citizen", citizenRequist.Email);
                    }
                    catch (Exception ex)
                    {

                    }
                    return Redirect("/Home/Citizin_ThanksPage");

                }
                TempData["RequestStatus"] = requestStatus;


                //added by Me


            }
            return result;

        }




        public ActionResult ContactUsHome()
        {
            //return Redirect("/Admission");
            return View();
        }

        [HttpPost]
        public ActionResult ContactUsHome(ContactRequist contat, HttpPostedFileBase uploadattachments)
        {

            ActionResult result = View(contat);

            if (ModelState.IsValid)
            {
                RequestStatus requestStatus;
                if (uploadattachments != null)
                {
                    requestStatus = new ManageRequestStatus().GetStatus(Status.GeneralError, "Plz Upload The Attachment");
                }
                else
                {
                    var ctx = new UnitOfWork();
                    ctx.ContactRquistManager.Add(contat);
                    requestStatus = new ManageRequestStatus().GetStatus(Status.Created);

                    try
                    {
                        SendEmail sendEmail = new SendEmail();
                        sendEmail.SendMail(new EmailDTO
                        {
                            To = "To Email",
                            Message = "<h1 style='font-size:25px; line-height:1.5'>New Contact Message</h1>"
                            + "<p style='font-size:15px; color: #000'>Thank You for connecting us.</p>" + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>First Name :</b>" + contat.FirstName + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Last Name :</b>" + contat.LastName + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Email :</b>" + contat.Email + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Phone :</b>" + contat.Phone + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Message:</b>" + contat.Message + "<br />" +
                            "<br />",
                            From = "web@empcnews.com",
                            Subject = "New Contact Us"
                        }, "Contact", contat.Email);
                    }
                    catch (Exception ex)
                    {

                    }

                    return Redirect("/Home/ContactUs_ThanksPage");

                }
                TempData["RequestStatus"] = requestStatus;
            }
            return result;

        }


        public ActionResult Booking()
        {
            //return Redirect("/Admission");
            return View();
        }

        [HttpPost]
        public ActionResult Booking(Booking booking, HttpPostedFileBase uploadattachments)
        {

            ActionResult result = View(booking);

            if (ModelState.IsValid)
            {
                RequestStatus requestStatus;
                if (uploadattachments != null)
                {
                    requestStatus = new ManageRequestStatus().GetStatus(Status.GeneralError, "Plz Upload The Attachment");
                }
                else
                {
                    var ctx = new UnitOfWork();
                    ctx.BookingManager.Add(booking);
                    requestStatus = new ManageRequestStatus().GetStatus(Status.Created);

                    var LiveStudio = "";
                    var StandUpPosition = "";
                    var TapeLayout = "";
                    var EngCrew = "";
                    var NewsPackage = "";
                    var Edite = "";
                    var Uplink = "";
                    var SataliteSpace = "";
                    var Production = "";
                    var SNG = "";
                    var OBVAN = "";
                    var Other = "";



                    if (booking.LiveStudio == true) { LiveStudio = "Live Studio, "; }
                    if (booking.StandUpPosition == true) { StandUpPosition = "Stand Up Position, "; }
                    if (booking.TapeLayout == true) { TapeLayout = "Tape Layout, "; }
                    if (booking.EngCrew == true) { EngCrew = "Eng Crew_"; }
                    if (booking.NewsPackage == true) { NewsPackage = "News Package, "; }
                    if (booking.Edite == true) { Edite = "Edite, "; }
                    if (booking.Uplink == true) { Uplink = "Uplink, "; }
                    if (booking.SataliteSpace == true) { SataliteSpace = "Satalite Space, "; }
                    if (booking.Production == true) { Production = "Production, "; }
                    if (booking.SNG == true) { SNG = "SNG, "; }
                    if (booking.OBVAN == true) { OBVAN = "OBVAN, "; }
                    if (booking.Other == true) { Other = "Other"; }

                    try
                    {


                        SendEmail sendEmail = new SendEmail();
                        sendEmail.SendMail(new EmailDTO
                        {
                            To = "To Email",
                            Message = "<h1 style='font-size:25px; line-height:1.5'>New Booking Request</h1> "
                            + "<p style = 'font-size:15px; color: #000;'> Thank you for your email and we will get back to you soon with our confirmation.</p>" + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Company Name :</b>" + booking.CompanyName + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Company Email :</b>" + booking.CompanyEmail + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Date Services :</b>" + booking.DataServicees + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Sart Time :</b>" + booking.SartTime + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>End Time:</b>" + booking.EndTime + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Origin:</b>" + booking.Origin + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Type of Services:</b>"
                            + LiveStudio
                            + StandUpPosition
                            + TapeLayout
                            + EngCrew
                            + NewsPackage
                            + Edite
                            + Uplink
                            + SataliteSpace
                            + Production
                            + SNG
                            + OBVAN
                            + Other
                            + "<br />"
                            + "<b style='font-size:12px; line-height:1.5'>Message:</b>" + booking.Message + "<br />" +
                            "<br />",
                            From = "web@empcnews.com",
                            Subject = "New Booking"
                        }, "booking", booking.CompanyEmail);
                    }
                    catch (Exception ex)
                    {

                    }

                    return Redirect("/Home/Booking_ThanksPage");

                }
                TempData["RequestStatus"] = requestStatus;
            }
            return result;

        }

        public ActionResult Booking_ThanksPage()
        {
            return View();
        }

        public ActionResult Citizin_ThanksPage()
        {
            return View();
        }

        public ActionResult ContactUs_ThanksPage()
        {
            return View();
        }


        public ActionResult DynamicPage()
        {
            return View();
        }

        public ActionResult ChangeLanguage(string SelectedLanguage, string redirect)
        {

            var controller = RouteData.Values["controller"].ToString();
            var action = RouteData.Values["action"].ToString(); ;
            if (SelectedLanguage != null)
            {
                Thread.CurrentThread.CurrentCulture =
                    CultureInfo.CreateSpecificCulture(SelectedLanguage);
                Thread.CurrentThread.CurrentUICulture =
                    new CultureInfo(SelectedLanguage);
                var cookie = new HttpCookie("Language");
                cookie.Value = SelectedLanguage;
                Response.Cookies.Add(cookie);
            }
            if (redirect == null)
            {
                redirect = "/";
               
            }
            return Redirect(redirect);
        }

        //public ActionResult Changethems(string redirect)
        //{

        //    var controller = RouteData.Values["controller"].ToString();
        //    var action = RouteData.Values["action"].ToString(); ;


        //    var cookie = Request.Cookies["thems"];
        //    if (cookie == null)
        //    {
        //        cookie = new HttpCookie("thems");
        //        cookie.Value = "default";
        //    }
        //    else
        //    {
        //        cookie.Value = (cookie.Value == "dark") ? "default" : "dark";
        //    }
        //    Response.Cookies.Add(cookie);
        //    if (redirect == null)
        //        redirect = "/";
        //    return Redirect(redirect);
        //}


        //public ActionResult  LiveSession()
        //{

        //    int userid = int.Parse(Request.Cookies["UserId"].Value);
        //    var student = ctx.StudentManager.GetAll().FirstOrDefault(c => c.UserId == userid);
        //    if (student == null) return RedirectToAction("Index");
        //    int GradeId = ctx.AppointmentGroupManager.GetBy(ctx.StudentManager.GetAllBind().FirstOrDefault(c => c.UserId == student.UserId) != null ? ctx.StudentManager.GetAllBind().FirstOrDefault(c => c.UserId == student.UserId).AppointmentGroupId : 0) != null ? ctx.AppointmentGroupManager.GetBy(ctx.StudentManager.GetAllBind().FirstOrDefault(c => c.UserId == student.UserId) != null ? ctx.StudentManager.GetAllBind().FirstOrDefault(c => c.UserId == student.UserId).AppointmentGroupId : 0).GradeId : 0;
        //    var result = ctx.LiveVideoManger.GetAllBind().Where(c => c.IsActive == true && (c.GroupId == student.AppointmentGroupId || c.GradeId == GradeId)).ToList();
        //    return View(result);
        //}

    }
}