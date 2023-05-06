using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class itemfood : UserControl
    {
        private string Name;
        private string Price;
        private string Count;


        public string name { get { return Name; } set { Name = value; lbl_name.Text = value; } }
        public string price { get { return Price; } set { Price = value; lbl_price.Text = value; } }
        public string count { get { return Count; } set { Count = value; lbl_count.Text = value; } }


        public itemfood()
        {
            InitializeComponent();
        }

      
        [Browsable(true)]
        public event EventHandler UserControlClicked;
        public void ControlClicked(object sender, EventArgs e)
        {
            //raise event
            UserControlClicked?.Invoke(this, e);
        }

      
    }
}
