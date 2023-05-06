using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Drawing;
using System.Linq;
using WindowsFormsApp1.Models.Food;
using WindowsFormsApp1.DAL.APIService.Food;
using DevComponents.DotNetBar;
using System.Web.UI;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApp1.Models.Tables;
using System.Web.UI.WebControls;
using Table = WindowsFormsApp1.Models.Tables.Table;

namespace WindowsFormsApp1.UI.Oder
{
    public partial class OderFood : Form
    {

        Table table = new Models.Tables.Table();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        FoodData food;
        itemfood itemcontrol;
        List<string> list = new List<string>()
        { 
            "1","2","3"
        };
        public OderFood(Table table)
        {
            InitializeComponent();
            this.table = table;
            LoadData();

        }

        private async void LoadData()
        {
            layout_food.Controls.Clear();
            food = await APIFood.Instance.GetAll();
            foreach (var item in food.data.data)
            {
                cbn_chonse.DataSource = list;
               
                    itemcontrol = new itemfood();
                    itemcontrol.Tag = item.id;
                    itemcontrol.UserControlClicked += Itemcontrol_UserControlClicked;
                    itemcontrol.name = item.name;
                    itemcontrol.Click += Itemcontrol_Click;
                    itemcontrol.price = string.Format(" {0:C}",item.price) + " " + "VND";
                    itemcontrol.count = item.count.ToString();


                layout_food.Controls.Add(itemcontrol);
                
            }
            lbl_table.Text = table.name;
            lbl_sum.Text = string.Format(" {0:C}", 202000) + " " + "VND";

        }

        private void Itemcontrol_Click(object sender, EventArgs e)
        {
            itemfood oj = (itemfood)sender;

            SetClickButton(oj,null);
        }

        private void Itemcontrol_UserControlClicked(object sender, EventArgs e)
        {

        }







        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void SetClickButton(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control c in layout_food.Controls)
            {
                c.BackColor = Color.White;
                c.ForeColor = Color.Black;
            }
            System.Windows.Forms.Control Click = sender as System.Windows.Forms.Control;
            Click.BackColor = Color.Gray;
            Click.ForeColor = Color.White;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
