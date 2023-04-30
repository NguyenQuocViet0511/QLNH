using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL.APIService.Category;
using WindowsFormsApp1.DAL.APIService.Food;
using WindowsFormsApp1.DAL.APIService.Table;
using WindowsFormsApp1.DAL.Sqlserver;
using WindowsFormsApp1.Models.Tables;

namespace WindowsFormsApp1.UI.QLTable
{
    public partial class QLTable : Form
    {
        TableData Table;
        public QLTable()
        {
            InitializeComponent();
            loadData();
        }

        public async void loadData()
        {
            Table = await APITable.Instance.GetAll();
            dgv_table.DataSource = Table.data.data;
            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("text", Table.data.data, "id");
            txt_nametable.DataBindings.Clear();
            txt_nametable.DataBindings.Add("text", Table.data.data, "name");
            txt_tablestatus.DataBindings.Clear();
            txt_tablestatus.DataBindings.Add("text", Table.data.data, "status");
        }
        private void Add()
        {
            if (APITable.Instance.ClickAdd)
            {
                clearText("");
                APITable.Instance.ClickAdd = false;
                txt_nametable.Enabled = true;
                btn_add.Text = "Đồng Ý";
                //event add
            }
            else
            {

                //envent
                if (MessageBox.Show("Bạn có muôn Thêm Sản Phẩm Mới Không", "thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    APITable.Instance.ClickAdd = true;
                    txt_nametable.Enabled = false;
              
                    btn_add.Text = "Thêm";
                    //add new 
                    Checkempty();


                }

                APITable.Instance.ClickAdd = true;
                txt_nametable.Enabled = false;
                btn_add.Text = "Thêm";
                loadData();

            }
        }
        private void clearText(string text)
        {
            txt_nametable.Text = text;
            txt_tablestatus.Text = text;
            txt_id.Text = text;
        }
        private void Checkempty()
        {
            if (string.IsNullOrEmpty(txt_nametable.Text))
            {
                MessageBox.Show("Vui Lòng Nhập đầy đủ vô ");

            }
            else
            {
                //MessageBox.Show(Result);
                loadData();
            }
        }
        private void dgv_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void dgv_table_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    
    }
}
