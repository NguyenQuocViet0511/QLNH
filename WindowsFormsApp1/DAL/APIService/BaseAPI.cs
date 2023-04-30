using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.DAL.APIService
{
    public class BaseAPI : BaseAPIInterFace
    {

        private static BaseAPI instance;

        public static BaseAPI Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaseAPI();
                return instance;

            }
            set => instance = value;
        }

        public  String All(string url, NameValueCollection Table, string Method)
        {
            WebClient Client = new WebClient();
            //Client.Headers[HttpRequestHeader.ContentType] = "application/json";
            Client.Encoding  = Encoding.UTF8;
            var responsebytes = Client.UploadValues(url, Method, Table);
            string reponsive = UnicodeEncoding.UTF8.GetString(responsebytes);
            return reponsive;
        }

   
        public string Get(string url)
        {
            WebClient Client = new WebClient();
            var json = Client.DownloadString(url);
            return json;
        }
    }
}