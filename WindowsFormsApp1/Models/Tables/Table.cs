using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Tables
{
    public class Table
    {
        
        private string ID;
        private string Name;
        private string Status;
        private string Id_bill;

        public Table()
        {

        }
        public Table(string id, string name, string status,string id_bill)
        {
            this.ID = id;
            this.Name = name;
            this.status = status;
            this.Id_bill = id_bill;

        }

        public string id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public string status { get => Status; set => Status = value; }
        public string id_bill { get => Id_bill; set => Id_bill = value; }
    }
}
