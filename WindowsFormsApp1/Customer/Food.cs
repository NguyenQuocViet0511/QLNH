using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Customer
{
    public partial class Food : UserControl
    {
        public Food()
        {
            InitializeComponent();
        }

        public void data(string lbl_sum ,string lbl_name)
        {
            this.lbl_sum.Text = lbl_sum;
            this.lbl_name.Text = lbl_name;
        }
       
    }
}
