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

namespace WindowsFormsApp1.DAL.APIService.Category
{
    public class APICategory
    {
        private static APICategory instance;

        public static APICategory Instance
        {
            get
            {
                if (instance == null)
                    instance = new APICategory();
                return instance;

            }
            set => instance = value;
        }


        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }

        public CategoryData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "category/list");
            if (Result == null)
            {
                return null;
            }
            CategoryData data = JsonConvert.DeserializeObject<CategoryData>(Result);
            return data;
        }
        public async Task<string> Add(string name)
        {
            NameValueCollection table = new NameValueCollection();
            table["name"] = name;
            string Result = BaseAPI.Instance.All(Const.URL + "category/create", table, "POST");
            return Result;
        }
        public async Task<string> Edit(string id, string name)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["name"] = name;
            string Result = BaseAPI.Instance.All(Const.URL + "category/update", table, "POST");
            return Result;
        }
        public async Task<string> delete(string id)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            string Result = BaseAPI.Instance.All(Const.URL + "category/delete", table, "POST");
            return Result;
        }


    }
}
