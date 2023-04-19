using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL.Sqlserver
{
    internal class category
    {
        private static category instance;
        public static category Instance
        {
            get { if (instance == null)
                    instance = new category();
            return instance;}
            set { instance = value; }
        }
        public DataTable getcategory()
        {
            DataTable dt = Query.Instance.ExecuteQuery("Getcategory");
            return dt;
        }
    }
}
