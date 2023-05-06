using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Category
{
    public class Category
    {

        private string ID;
        private string Name;


        public Category()
        {

        }
        public Category(string id, string name)
        {
            this.ID = id;
            this.Name = name;
 
        }

        public string id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }

    }
}
