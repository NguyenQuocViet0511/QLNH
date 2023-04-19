using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Tables
{
    public class Table
    {
        
        private string id;
        private string name;
        private string status;

        public Table()
        {

        }
        public Table(string id, string name, string status)
        {
            this.id = id;
            this.Name = name;
            this.Status = status;

        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
    }
}
