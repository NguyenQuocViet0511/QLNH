using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAL.Sqlserver
{
    internal class ConnectSever
    {

        private static ConnectSever instance;
        private static String QueryConnect = "server=DESKTOP-34Q185T;database = ManagerRertaurants; Integrated security = true";


        public static ConnectSever Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConnectSever();
                return instance;

            }
            set { instance = value; }
        }

        public SqlConnection Connection()
        {
            SqlConnection conn = null;

            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(QueryConnect);
                    conn.Open();
                }
            }

                
                catch (Exception)
                {

                MessageBox.Show("Error Connect");
                }
            


            return conn;
        }

    }
}
