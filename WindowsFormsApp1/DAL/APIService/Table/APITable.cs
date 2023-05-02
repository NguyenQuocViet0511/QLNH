using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using WindowsFormsApp1.Models.Tables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.DAL.APIService.Table
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



        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }


        public async Task<TableData> GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "tables/list");
            if(Result == null)
            {
                return null;
            }    
            TableData data = JsonConvert.DeserializeObject<TableData>(Result);
            return data;
     

        }
        public String Add(string name)
        {
            NameValueCollection table = new NameValueCollection();
            table["name"] = name;
            string Result = BaseAPI.Instance.All(Const.URL + "tables/create", table, "POST");
            return Result;
        }
        public String Edit(string id,string name)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["name"] = name;
            string Result = BaseAPI.Instance.All(Const.URL + "tables/update", table, "POST");
            return Result;
        }

        public String UpdateByIDbill(string id, string name, string status, string id_bill)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["name"] = name;
            table["status"] = status;
            table["id_bill"] = id_bill;
            string Result = BaseAPI.Instance.All(Const.URL + "tables/update", table, "POST");
            return Result;
        }
        public String delete(string id)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            string Result = BaseAPI.Instance.All(Const.URL + "tables/delete", table, "POST");
            return Result;
        }


    }
}
