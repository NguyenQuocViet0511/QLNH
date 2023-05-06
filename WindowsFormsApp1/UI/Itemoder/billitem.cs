using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Customer;

namespace WindowsFormsApp1.UI.Itemoder
{
    public partial class billitem : Form
    {
        public billitem()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            layout_oder.Controls.Clear();
            for(int i = 0; i < 10; i++)
            {
                itemoder itemoder = new itemoder();
                layout_oder.Controls.Add(itemoder);
            }    
         
        }
    }
}
