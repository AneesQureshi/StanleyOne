using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace StanleyOne.Models
{
    public class ContactUsModel
    {
        public string userName { get; set; }
        public string email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }




        public string ContactUs(ContactUsModel contact)
            {
            string result = "";
            try
                {

                string service = ApiPath.ContactUsPath;
                var response = ApiConnect.PostData(service, contact);
                if (response != null || response.IsSuccessStatusCode)
                    {
                    string jresult = response.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<string>(jresult);

                    }
                }
            catch (Exception ex)
                {
                string msg = ex.Message;
                }
            return result;
            }
        }
}