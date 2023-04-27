using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DAL.APIController;
using WindowsFormsApp1.DAL.APIController.Table;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Models.Tables;

namespace WindowsFormsApp1
{
    public partial class f_login : Form
    {
        public f_login()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //if (Users.Instance.CheckLogin(txtUserName.Text, txtPassWord.Text).Rows.Count > 0)
            //{
            MessageBox.Show("Đăng Nhập thành công");
                new f_Home().Show();
            this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("wrong acount or password");

            //}




        }
 
    }
}
