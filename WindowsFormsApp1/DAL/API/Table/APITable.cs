using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using WindowsFormsApp1.Models.Tables;

namespace WindowsFormsApp1.DAL.API.Table
{
    public class APITable 
    {
        private static APITable instance;

        public static APITable Instance
        {
            get
            {
                if (instance == null)
                    instance = new APITable();
                return instance;

            }
            set => instance = value;
        }



        string url = "http://127.0.0.1:8000/api/tables/";

        
        public MyData GetAll()
        {   
            string Result = BaseAPI.Instance.Get(url + "list");
            MyData data = JsonConvert.DeserializeObject<MyData>(Result);
            return data;
        }


    }
}
