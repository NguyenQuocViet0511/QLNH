using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class staffDao
    {
        private string staffId;
        private string staffName;
        private string birthday;
        private string sex;
        private string number;
        private string address;
        private string idusers;


        public staffDao() { }

        public staffDao(string staffId, string staffName, string birthday, string sex, string number, string address,string idusers)
        {
            this.staffId = staffId;
            this.staffName = staffName;
            this.birthday = birthday;
            this.sex = sex;
            this.number = number;
            this.Address = address;
            this.idusers = idusers;
          
        }

        public string StaffId { get => staffId; set => staffId = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Number { get => number; set => number = value; }
        public string Address { get => address; set => address = value; }

        public string Idusers { get => idusers; set => idusers = value; }
    }
}
