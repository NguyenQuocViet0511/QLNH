using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL.Sqlserver
{
    internal class Users
    {
        private static Users instance;
        public static Users Instance
        {
            get
            {
               if (instance == null)
                    instance = new Users();
               return instance;
            }
            set { instance = value; }
       
        }

        public DataTable CheckLogin(string username, string password)
        {
            DataTable dt = Query.Instance.ExecuteQuery("Getlogin @username , @password", new object[]
            {
                username,password
            });
            return dt;
        }
            

        }
    }

