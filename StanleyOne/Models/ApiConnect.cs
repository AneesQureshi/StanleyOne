using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;



namespace StanleyOne.Models
    {
    public class ApiConnect
        {

        //for getting data from api
        public static HttpResponseMessage GetData(string uri)
            {

            HttpResponseMessage response = null;
            try
                {
                using (var client = new HttpClient())
                    {
                    string con = ApiPath.StanleyOneApi;
                    client.BaseAddress = new Uri(con);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    response = client.GetAsync(uri).Result;
                    }
                }
            catch (Exception ex)
                {
                string msg = ex.Message;
                }
            return response;

            }

        // for posting data to api
        public static HttpResponseMessage PostData(string uri, object jdata)
            {

            HttpResponseMessage response = null;
            try
                {
                
                using (var client = new HttpClient())
                    {

                    string con = ApiPath.StanleyOneApi;
                    client.Timeout = TimeSpan.FromMinutes(30);
                    client.BaseAddress = new Uri(con);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    
                    response = client.PostAsJsonAsync(uri, jdata).Result;
                    
                    }
                return response;

                // RunAsync(uri,jdata).Wait();
                }
            catch (Exception ex)
                {
                string msg = ex.Message;
                }
            return response;
            }

        }
    }