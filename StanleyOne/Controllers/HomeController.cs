using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StanleyOne.Models;

namespace StanleyOne.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactUs(string name,string email,string subject,string message)
            {
            ContactUsModel contact = new ContactUsModel();
            contact.userName = name;
            contact.email = email;
            contact.Subject = subject;
            contact.Message = message;
            string result = contact.ContactUs(contact);
            if(result=="success")
                {
                return Json(result, JsonRequestBehavior.AllowGet);
                }
            else
                {
                return Json("fail", JsonRequestBehavior.AllowGet);
                }

           
            }
    }
}