using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Category
{
    public class Category
    {

        private int ID;
        private string Name;
        private double Price;
        private double Discount;
        private int Count;
        private string Images;
        private int Id_category;
        private string category_name;

        public Category()
        {

        }
        public Category(int id, string name, double price, double discount, int count, string images, int id_category,string category_name)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.count = count;
            this.images = images;
            this.id_category = id_category;
            this.category_name = category_name;
        }

        public int id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public double price { get => Price; set => Price = value; }
        public double discount { get => Discount; set => Discount = value; }
        public int count { get => Count; set => Count = value; }
        public string images { get => Images; set => Images = value; }
        public int id_category { get => Id_category; set => Id_category = value; }
        public string Category_name { get => category_name; set => category_name = value; }
    }
}
