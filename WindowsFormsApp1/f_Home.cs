using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL.APIService.Table;
using WindowsFormsApp1.Models.Tables;
using WindowsFormsApp1.UI.Itemoder;
using WindowsFormsApp1.UI.Map;
using WindowsFormsApp1.UI.Oder;

namespace WindowsFormsApp1
{
    public partial class f_Home : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
            if(MessageBox.Show("Bạn có muôn thoát chương trình không","thông báo",MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                Application.Exit();

            }
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
           
            f_QL f_QL = new f_QL();
            f_QL.ShowDialog();


        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
    
        }


 
  

        private void btnoder_Click(object sender, EventArgs e)
        {
          
                panel_controller.Controls.Clear();
                billitem itemoder = new billitem();
                itemoder.Dock = DockStyle.Fill;
                itemoder.TopLevel = false;
                panel_controller.Controls.Add(itemoder);
                itemoder.Show();
             
           
        }

        private void btn_map_Click(object sender, EventArgs e)
        {
            panel_controller.Controls.Clear();
            Map map = new Map();
            map.Dock = DockStyle.Fill;
            map.TopLevel = false;
            panel_controller.Controls.Add(map);
            map.Show();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
