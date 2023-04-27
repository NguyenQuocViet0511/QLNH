using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Tables
{
    public class Table
    {
        
        private int ID;
        private string Name;
        private string Status;

        public Table()
        {

        }
        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.status = status;

        }

        public int id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public string status { get => Status; set => Status = value; }
    }
}
