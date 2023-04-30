using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using WindowsFormsApp1.Models.Category;
using WindowsFormsApp1.Models.Food;

namespace WindowsFormsApp1.DAL.APIService.Food
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

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public async Task<FoodData> GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "food/list");
            FoodData data = JsonConvert.DeserializeObject<FoodData>(Result);
            return data;
        }
        public async Task<string> Add(string name,string price,string discount,string id_category)
        {
            NameValueCollection table = new NameValueCollection();
            table["name"] = name;
            table["price"] = price;
            table["discount"] = discount;
            table["count"] = "0";
            table["id_category"] = id_category;
            string Result = BaseAPI.Instance.All(Const.URL + "food/create", table, "POST");
            return Result;
        }
        public async Task<string> Edit(string id,string name, string price, string discount, string id_category)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["name"] = name;
            table["price"] = price;
            table["discount"] = discount;
            table["id_category"] = id_category;
            string Result = BaseAPI.Instance.All(Const.URL + "food/update", table, "POST");
            return Result;
        }
        public async Task<string> delete(string id)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            string Result = BaseAPI.Instance.All(Const.URL + "food/delete", table, "POST");
            return Result;
        }
    }
}
