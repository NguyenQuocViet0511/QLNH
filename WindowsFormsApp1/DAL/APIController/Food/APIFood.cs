using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.UI.WebControls;
using WindowsFormsApp1.Models.Food;

namespace WindowsFormsApp1.DAL.APIController.Food
{
    public class APIFood
    {
        private static APIFood instance;

        public static APIFood Instance
        {
            get
            {
                if (instance == null)
                    instance = new APIFood();
                return instance;

            }
            set => instance = value;
        }




        public MyData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "food/list");
            MyData data = JsonConvert.DeserializeObject<MyData>(Result);
            return data;
        }
        public String Post()
        {
            //WindowsFormsApp1.Models.Tables.Table  table = new Models.Tables.Table();
            NameValueCollection table = new NameValueCollection();
            table["name"] = "B22";
            table["status"] = "No";
            string Result = BaseAPI.Instance.All(Const.URL + "create", table, "POST");
            return Result;
        }


    }
}
