using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL.APIService.Table;
using WindowsFormsApp1.Models.Tables;

namespace WindowsFormsApp1
{
    public partial class f_Home : Form
    {
        TableData Table;
        DevComponents.DotNetBar.ButtonX button;

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
            f_ODER f_ODER = new f_ODER();   
            f_ODER.ShowDialog();    
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async Task LoadMapAsync()
        {
            panel_Map.Controls.Clear();
            Table = await APITable.Instance.GetAll();
            for(int i =0; i<20;i++)
            {
                button = new DevComponents.DotNetBar.ButtonX();
                button.Text = "Bàn" + " " + i;
                button.Height = 130;
                button.Width = 200;           
                button.Click += Button_Click;
                button.Tag = i + " " + button.Text;
                panel_Map.Controls.Add(button);
            }    
            
        }
        private void SetColorClick(object sender, EventArgs e)
        {
            foreach (Control c in panel_Map.Controls)
            {
                c.BackColor = Color.Black;
                c.ForeColor = Color.Black;
            }
            Control Click = (Control)sender;
            Click.BackColor = Color.Black;
            Click.ForeColor = Color.Red;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonX button = sender as DevComponents.DotNetBar.ButtonX;
            MessageBox.Show(" " + button.Tag.ToString());
            SetColorClick(button, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadMapAsync();
        }
    }
}
