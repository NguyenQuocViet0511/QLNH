using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

using WindowsFormsApp1.UI.QLMenu;

namespace WindowsFormsApp1
{
    public partial class f_QL : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public f_QL()
        {
            InitializeComponent();
        }

     

 

        private void btn_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadFileSteam = new OpenFileDialog();

            uploadFileSteam.InitialDirectory = "c:\\";
            uploadFileSteam.Filter = "picture|*.jpg;*.png";
            uploadFileSteam.FilterIndex = 2;

            if (uploadFileSteam.ShowDialog() == DialogResult.OK)
            {
                /*                File.Copy(uploadFileSteam.FileName, Directory.GetCurrentDirectory() + "\\Data\\" + uploadFileSteam.SafeFileName);
                */
            }
        }


        private void f_QL_Load(object sender, EventArgs e)
        {
       
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muôn thoát trang quản lý không", "thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            QLMenu menu = new QLMenu();
            Const.Instance.CheckExistingTab(ManagerTabController,"Quản Lí Menu", menu);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
