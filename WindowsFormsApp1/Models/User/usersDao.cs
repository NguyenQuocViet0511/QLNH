using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class usersDao
    {
        private string username;
        private string password;
        private string status;
        private string lastlogin;

        public usersDao() { 
        }
        public usersDao(string username, string password, string status, string lastlogin)
        {
            this.username = username;
            this.password = password;
            this.status = status;
            this.lastlogin = lastlogin;
       
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Status { get => status; set => status = value; }
        public string Lastlogin { get => lastlogin; set => lastlogin = value; }
    }
}
