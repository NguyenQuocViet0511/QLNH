using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL.Sqlserver
{
    internal class food
    {
        private static food instance;
        public static food Instance
        {
            get { if (instance == null)
                    instance = new food();
            return instance;
            }
            set { instance = value; }
        }

        public DataTable getfood()
        {
            DataTable dt = Query.Instance.ExecuteQuery("Getfood");
            return dt;
        }
    }
}



































