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

namespace WindowsFormsApp1.DAL.API
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

        public string All(string url, NameValueCollection table, string Method)
        {
            WebClient Client = new WebClient();
            var responsebytes = Client.UploadValues(url, Method, table);
            string responsebody = Encoding.UTF8.GetString(responsebytes);
            return responsebody;
        }

        public string All(string url, string Method, NameValueCollection table = null)
        {
            throw new NotImplementedException();
        }

        public string Get(string url)
        {
            WebClient Client = new WebClient();
            var json = Client.DownloadString(url);
            return json;
        }
    }
}