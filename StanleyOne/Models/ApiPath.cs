using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace StanleyOne.Models
    {
    public static class ApiPath
        {
        public static string StanleyOneApi = ConfigurationManager.AppSettings["StanleyOneAPI"];
       
        public static string ContactUsPath = "api/HomeController/ContactUs";
        }
    }