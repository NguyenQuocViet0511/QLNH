using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class f_Home : Form
    {
        public f_Home()
        {
            InitializeComponent();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
           
            f_QL f_QL = new f_QL();
            f_QL.ShowDialog();
        

        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            f_ODER f_ODER = new f_ODER();   
            f_ODER.ShowDialog();    
        }

      
    }
}
